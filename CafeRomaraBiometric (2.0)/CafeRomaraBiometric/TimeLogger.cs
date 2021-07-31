using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace CafeRomaraBiometric
{
    class TimeLogger
    {
        private MySql.Data.MySqlClient.MySqlConnection connection;
        private TimeCalculator calculator;
        private EmployeeModel employeeModel;
        private IPreference preference;
        private IFingerprintsModel fingerModel;
        private const float DEFAULT_WORK_HOURS=8f;

        public TimeLogger(MySql.Data.MySqlClient.MySqlConnection connection, TimeCalculator calculator, EmployeeModel employeeModel)
        {
            this.connection = connection;
            this.calculator = calculator;
            this.employeeModel = employeeModel;
        }

        public void setPreference(IPreference preference)
        {
            this.preference = preference;
        }

        public void setFingerModel(IFingerprintsModel fingerModel)
        {
            this.fingerModel = fingerModel; 
        }

        public IPreference getPreference()
        {
           return this.preference;
        }




        private string getDateToday()
        {
            return DateTime.Today.ToString("yyyy-MM-dd");
           
        }
        private string getCurrentTime()
        {
            return DateTime.Now.ToString("HH:mm:ss");
        }



        private bool isThis(string columnName,int employeeId)
        {
            connection.Open();
            string sql = "SELECT * FROM time_logs WHERE employee_id=@emp_id AND log_date=@log_date AND "+columnName+" IS NOT NULL";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@emp_id", employeeId);
            cmd.Parameters.AddWithValue("@log_date", getDateToday());
            MySqlDataReader reader = cmd.ExecuteReader();
            bool res = reader.HasRows ? false : true;
            connection.Close();

            return res;
        }

        private bool isTimeInAm(int employeeId)
        {
            return isThis("time_in", employeeId);
        }
        private bool isTimeOutAm(int employeeId)
        {
            return isThis("time_out_am", employeeId);
        }

        private bool isTimeInPm(int employeeId)
        {
            return isThis("time_in_pm", employeeId);
        }
        private bool isTimeOutPm(int employeeId)
        {
            return isThis("time_out", employeeId);
        }


        private void logTimeInAm(int employeeId)
        {
            connection.Open();
            string sql = "INSERT INTO time_logs(time_in,employee_id,log_date) VALUES(@timeIn,@empId,@logDate)";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@timeIn", getCurrentTime());
            cmd.Parameters.AddWithValue("@empId",employeeId);
            cmd.Parameters.AddWithValue("@logDate", getDateToday());
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void updateTime(string columnName, int employeeId,string time)
        {
            connection.Open();
            string sql = "UPDATE time_logs SET "+columnName + "=@currentTime WHERE employee_id=@empId AND log_date=@logDate";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@currentTime", time);
            cmd.Parameters.AddWithValue("@empId", employeeId);
            cmd.Parameters.AddWithValue("@logDate", getDateToday());
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void logMinsLateAm(double minsLate,int employeeId)
        {  
            connection.Open();
            string sql = "UPDATE time_logs SET mins_late=@minsLate WHERE employee_id=@empId AND log_date=@logDate";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@minsLate", minsLate);
            cmd.Parameters.AddWithValue("@empId", employeeId);
            cmd.Parameters.AddWithValue("@logDate", getDateToday());
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void updateMinsLate(int minsLate,int employeeId)
        {
            connection.Open();
            string sql = "UPDATE time_logs SET mins_late=@minsLate WHERE employee_id=@empId AND log_date=@logDate";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@minsLate", minsLate);
            cmd.Parameters.AddWithValue("@empId", employeeId);
            cmd.Parameters.AddWithValue("@logDate", getDateToday());
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public bool log(int employeeId,TimeLogModel timeLogModel)
        {

            Accountant account=new Accountant();

            if (isTimeInAm(employeeId))
            {
                logTimeInAm(employeeId);
                double minsLate=0;
                if (this.fingerModel.getTypeById(employeeId) == "Normal")
                {
                 
                    string expectedTimeInStr = this.employeeModel.getTimeIn(employeeId);
                    DateTime expectedTimeIn = StrTimeParser.parse(expectedTimeInStr).AddMinutes(30);
                    DateTime exactTimeIn = StrTimeParser.parse(getCurrentTime());

                    minsLate = calculator.zeroOrMinsDifference(expectedTimeIn, exactTimeIn);
                  
                }
                else
                {
                    minsLate = 0;
                   
                }
                 logMinsLateAm(minsLate, employeeId);
             

            }
            else if (isTimeOutPm(employeeId))
            {

                if (this.fingerModel.getTypeById(employeeId) == "Normal")
                {
                    updateTime("time_out", employeeId, getCurrentTime());

                    string scheduledTimeOutStr = this.employeeModel.getTimeOut(employeeId);

                    string actualTimeOut = getCurrentTime();

                    int maxOtMinutes = this.preference.getMaxOt();



                    double otHours = account.calculateHours(actualTimeOut, scheduledTimeOutStr);

                    if (otHours < 0) otHours = 0;

                    //check if employee's OT in minutes goes beyond the allowable OT minutes set by the Admin
                    double otInMins = otHours * 60;

                    bool isBeyondOtHours = this.preference.isBeyondMaxOt(otInMins);

                    //If it goes beyond, then we remove the excess and just calculate until the allowable OT minutes

                    if (isBeyondOtHours)
                    {
                        int maxOt = this.preference.getMaxOt();
                        double maxOtInHrs = maxOt / 60f;
                        otHours = maxOtInHrs;
                    }



                    timeLogModel.updateOt(otHours, employeeId, getDateToday());

                    double currentNumOfHours = timeLogModel.getCurrentNumOfHours(employeeId, getDateToday());

                    string actualTimeInAmStr = timeLogModel.getTimeInAm(employeeId, getDateToday());
                    string scheduledTimeIn = timeLogModel.getScheduledTimeIn(employeeId);

                    bool isEarlyTimeOut = (account.calculateHours(actualTimeOut, scheduledTimeOutStr) < 0);

                    double numOfHoursPm = 0;

                    numOfHoursPm = isEarlyTimeOut ? account.calculateHours(actualTimeOut, actualTimeInAmStr) : account.calculateHours(scheduledTimeOutStr, scheduledTimeIn);


                    double totalNumOfHours = currentNumOfHours + numOfHoursPm;
                    timeLogModel.updateNumOfHours((totalNumOfHours >= 7.5 ? 8 : totalNumOfHours), employeeId, getDateToday());

                    timeLogModel.updateTotalHours((totalNumOfHours >= 7.5 ? 8 : totalNumOfHours) + otHours, employeeId, getDateToday());

                }
                else
                {
                    updateTime("time_out", employeeId, getCurrentTime());

                    string timeInAm = timeLogModel.getTimeInAm(employeeId, getDateToday());
                    double hoursWorked = account.calculateHours(getCurrentTime(), timeInAm);

                    double otHours = 0;
                    bool hasOt=hoursWorked > DEFAULT_WORK_HOURS;
                    DateTime timeinAmDateTime = StrTimeParser.parse(timeInAm);
                    DateTime expectedTimeOut=timeinAmDateTime.AddHours(DEFAULT_WORK_HOURS);
                    
                    string expectedTimeOutStr=StrTimeParser.parseToStr(expectedTimeOut);


                    if (hasOt)
                    {

                        otHours = account.calculateHours(getCurrentTime(), expectedTimeOutStr);
                    }

                    double numOfHours=account.calculateHours(getCurrentTime(),timeInAm);
                    
                    bool isEarlyTimeOut=numOfHours<DEFAULT_WORK_HOURS;

                    if (!isEarlyTimeOut)
                    {
                        numOfHours = account.calculateHours(expectedTimeOutStr, timeInAm);

                    }

                    timeLogModel.updateOt(otHours, employeeId, getDateToday());

                    timeLogModel.updateNumOfHours((numOfHours >= 7.5 ? 8 : numOfHours), employeeId, getDateToday());

                    timeLogModel.updateTotalHours((numOfHours >= 7.5 ? 8 : numOfHours) + otHours, employeeId, getDateToday());

                }
               

            }
            else
            {
                return false;//which means he/she is done with the work day
            }

            return true; 
        }
        

    }
}
