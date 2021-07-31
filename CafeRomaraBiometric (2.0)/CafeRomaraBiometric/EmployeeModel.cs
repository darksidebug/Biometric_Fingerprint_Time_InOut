using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace CafeRomaraBiometric
{
    class EmployeeModel
    {
        private MySqlConnection connection;
        public EmployeeModel(MySqlConnection connection)
        {
            this.connection = connection;
        }

        public string getTimeOut(int employeeId)
        {
            this.connection.Open();
            string sql = "SELECT time_out FROM employees WHERE id=@empId";
            MySqlCommand command = new MySqlCommand(sql, this.connection);
            command.Parameters.AddWithValue("@empId", employeeId);
            MySqlDataReader reader = command.ExecuteReader();

            reader.Read();
            string timeOut = reader.GetString(0);
            this.connection.Close();
            return timeOut;
        }


 
        public string getTimeIn(int employeeId)
        {
            this.connection.Open();
            string sql="SELECT time_in FROM employees WHERE id=@empId";
            MySqlCommand command = new MySqlCommand(sql, this.connection);
            command.Parameters.AddWithValue("@empId", employeeId);
            MySqlDataReader reader = command.ExecuteReader();

            reader.Read();
            string timeIn=reader.GetString(0);
            this.connection.Close();
            return timeIn;
        }

        public int getBreak(int employeeId)
        {
            this.connection.Open();
            string sql = "SELECT break_mins FROM employees WHERE id=@empId";
            MySqlCommand command = new MySqlCommand(sql, this.connection);
            command.Parameters.AddWithValue("@empId", employeeId);
            MySqlDataReader reader = command.ExecuteReader();

            reader.Read();
            int breakMins = reader.GetInt32(0);
            this.connection.Close();
            return breakMins;
        }

    }
}
