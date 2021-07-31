using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace CafeRomaraBiometric
{
    class TimeSheetModel
    {
        private MySqlConnection connection;

        public TimeSheetModel(MySqlConnection connection)
        {
            this.connection = connection;

        }

      


        public TimeSheet getTimeSheet(int employeeId,string logDate)
        {
            this.connection.Open();
            string sql = "SELECT * FROM time_logs WHERE employee_id=@empId AND log_date=@logDate";
            MySqlCommand command = new MySqlCommand(sql,this.connection);
            command.Parameters.AddWithValue("@empId", employeeId);
            command.Parameters.AddWithValue("@logDate", logDate);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                TimeSheet timeSheet = new TimeSheet();
                timeSheet.TimeInAm = reader.GetString(1);
                timeSheet.TimeOutAm = reader.GetString(2);
                timeSheet.TimeInPm = reader.GetString(3);
                timeSheet.TimeOutPm = reader.GetString(4);
                this.connection.Close();
                return timeSheet;
            }
            this.connection.Close();
            return null;
        }

    }
}
