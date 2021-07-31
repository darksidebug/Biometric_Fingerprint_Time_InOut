using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace CafeRomaraBiometric
{
    class BaseEmployeeModel:IEmployeesModel
    {

        protected MySqlConnection conn;

        public BaseEmployeeModel(MySqlConnection conn) 
        {
            this.conn = conn;
        }


        public IEmployee getEmployeeById(int id)
        {
            conn.Open();
            string sql = "SELECT * FROM employees WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = cmd.ExecuteReader();

            int count = 0;

            BaseEmployee employee=null;

            while (reader.Read())
            {
                Dictionary<string,string> employeeInfo=new Dictionary<string,string>();
                 string empId=reader.GetString(0);
                 string firstName=reader.GetString(1);
                 string middlename = "";
                 if (!reader.IsDBNull(4))
                 {
                      middlename = reader.GetString(2);
                 }
               
                string lastname=reader.GetString(3);
                string suffix = "";
                if (!reader.IsDBNull(4))
                {
                     suffix = reader.GetString(4).ToString();
                }
               
                string timeIn=reader.GetString(7);
                string timeOut=reader.GetString(8);
                string breakMins=reader.GetString(9);


                employeeInfo.Add("id",empId);
                employeeInfo.Add("firstname", firstName);
                employeeInfo.Add("lastname", lastname);
                employeeInfo.Add("middlename", middlename);
                employeeInfo.Add("suffix", suffix);
                employeeInfo.Add("time_in", timeIn);
                employeeInfo.Add("time_out", timeOut);
                employeeInfo.Add("break_mins", breakMins);

                 employee = new BaseEmployee(employeeInfo);
                count++;
            }

            bool hasEmployee = employee!=null?true:false;
            conn.Close();
            if (hasEmployee) { return employee; }

            return null;
        }


        public string getFullnameById(int employeeId)
        {
            conn.Open();
            string sql = "SELECT firstname,lastname FROM employees WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            cmd.Parameters.AddWithValue("@id", employeeId);
            MySqlDataReader reader = cmd.ExecuteReader();

            reader.Read();
            string firstname = reader.GetString(0);
            string lastname = reader.GetString(1);

            conn.Close();

            return firstname + " " + lastname;

        }
    }
}
