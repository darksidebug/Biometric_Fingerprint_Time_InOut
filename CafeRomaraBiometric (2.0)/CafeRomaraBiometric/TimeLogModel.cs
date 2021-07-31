using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace CafeRomaraBiometric
{
    class TimeLogModel :AbstractModel
    {

        public TimeLogModel(MySqlConnection connection):base(connection)
        {
          
        }

        public void updateOt(double value, int employeeId, string logDate)
        {
            connection.Open();
            string[] ot = value.ToString().Split(new Char[] {'.'});
            string sql = "UPDATE time_logs SET num_of_ot=@Ot WHERE employee_id=@empId AND log_date=@logDate";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@Ot", ot[0]);
            cmd.Parameters.AddWithValue("@empId", employeeId);
            cmd.Parameters.AddWithValue("@logDate", logDate);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void updateTotalHours(double value, int employeeId, string logDate)
        {
            connection.Open();
            string[] ot = value.ToString().Split(new Char[] { '.' });
            string sql = "UPDATE time_logs SET total_hours=@totalHours WHERE employee_id=@empId AND log_date=@logDate";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@totalHours", ot[0]);
            cmd.Parameters.AddWithValue("@empId", employeeId);
            cmd.Parameters.AddWithValue("@logDate", logDate);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void updateNumOfHours(double numOfHours,int employeeId,string logDate)
        {
            connection.Open();
            string sql = "UPDATE time_logs SET num_of_hours=@numOfHours WHERE employee_id=@empId AND log_date=@logDate";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@numOfHours", numOfHours);
            cmd.Parameters.AddWithValue("@empId", employeeId);
            cmd.Parameters.AddWithValue("@logDate", logDate);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public string getTimeInPm(int employeeId, string logDate)
        {
            this.connection.Open();
            string sql = "SELECT time_in_pm FROM time_logs WHERE employee_id=@empId AND log_date=@logDate";
            MySqlCommand command = new MySqlCommand(sql, this.connection);
            command.Parameters.AddWithValue("@empId", employeeId);
            command.Parameters.AddWithValue("@logDate", logDate);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            string timeInPm = reader.GetString(0);
            this.connection.Close();
            return timeInPm;
        }
        public string getScheduledTimeIn(int employeeId)
        {
            this.connection.Open();
            string sql = "SELECT time_in FROM employees WHERE id=@empId";
            MySqlCommand command = new MySqlCommand(sql, this.connection);
            command.Parameters.AddWithValue("@empId", employeeId);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            string timeInAm = reader.GetString(0);
            this.connection.Close();
            return timeInAm;
        }


        public string getTimeInAm(int employeeId, string logDate)
        {
            this.connection.Open();
            string sql = "SELECT time_in FROM time_logs WHERE employee_id=@empId AND log_date=@logDate";
            MySqlCommand command = new MySqlCommand(sql, this.connection);
            command.Parameters.AddWithValue("@empId", employeeId);
            command.Parameters.AddWithValue("@logDate", logDate);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            string timeInAm = reader.GetString(0);
            this.connection.Close();
            return timeInAm;
        }

        public string getTimeOutAm(int employeeId, string logDate)
        {
            this.connection.Open();
            string sql = "SELECT time_out_am FROM time_logs WHERE employee_id=@empId AND log_date=@logDate";
            MySqlCommand command = new MySqlCommand(sql, this.connection);
            command.Parameters.AddWithValue("@empId", employeeId);
            command.Parameters.AddWithValue("@logDate", logDate);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            string timeOutAm=reader.GetString(0);
            this.connection.Close();
            return timeOutAm;
        }


        public double getCurrentNumOfHours(int employeeId, string logDate)
        {
            this.connection.Open();
            string sql = "SELECT num_of_hours FROM time_logs WHERE employee_id=@empId AND log_date=@logDate";
            MySqlCommand command = new MySqlCommand(sql, this.connection);
            command.Parameters.AddWithValue("@empId", employeeId);
            command.Parameters.AddWithValue("@logDate", logDate);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();

            bool isNumOfHoursNull=reader.IsDBNull(0);
            double numOfHours=0;
            if (!isNumOfHoursNull)
            {
                numOfHours = reader.GetDouble(0);
            }
            
            this.connection.Close();
            return numOfHours;
        }




        public int getMinsLate(int employeeId, string logDate)
        {
            this.connection.Open();
            string sql = "SELECT mins_late FROM time_logs WHERE employee_id=@empId AND log_date=@logDate";
            MySqlCommand command = new MySqlCommand(sql, this.connection);
            command.Parameters.AddWithValue("@empId", employeeId);
            command.Parameters.AddWithValue("@logDate", logDate);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int minsLate = reader.GetInt32(0);
            this.connection.Close();
            return minsLate;
        }


       
    }
}
