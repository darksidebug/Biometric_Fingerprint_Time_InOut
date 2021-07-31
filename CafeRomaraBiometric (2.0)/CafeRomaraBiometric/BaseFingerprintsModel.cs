using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace CafeRomaraBiometric
{
    class BaseFingerprintsModel:IFingerprintsModel
    {
        private MySql.Data.MySqlClient.MySqlConnection connection;
        private string[] validTypes = { "Special", "Normal" };
        public BaseFingerprintsModel(MySql.Data.MySqlClient.MySqlConnection connection)
        {
            this.connection = connection;
        }

        private byte[] prepareTemplate(DPFP.Template fingerprintTemplate)
        {
           byte[] fingerPrintBytes= null;
         
           fingerprintTemplate.Serialize(ref fingerPrintBytes);
           return fingerPrintBytes;
            
        }

        private bool validateAccountType(string type)
        {
            foreach (string validType in this.validTypes )
            {
                if(validType==type)
                {
                    return true;
                }
            }

            return false;
        }



        public void insert(int employeeId, DPFP.Template fingerprintTemplate,string type)
        {
            if (!this.validateAccountType(type))
            {
                throw new Exception("Invalid type");
            }

           this.connection.Open();
           byte [] fingerprintBytes= prepareTemplate(fingerprintTemplate);

        
           string sql = "INSERT INTO fingerprints(employee_id,fingerprint,type) VALUES(@emp_id,@finger,@type)";
           MySqlCommand cmd = new MySqlCommand(sql, this.connection);
           cmd.Parameters.AddWithValue("@emp_id", employeeId);
           cmd.Parameters.AddWithValue("@finger", fingerprintBytes);
           cmd.Parameters.AddWithValue("@type", type);
           cmd.ExecuteNonQuery();
           this.connection.Close();
        }


        public string getTypeById(int employeeId)
        {
            this.connection.Open();
            string sql = "SELECT type FROM fingerprints WHERE employee_id=@emp_id";
            MySqlCommand cmd = new MySqlCommand(sql, this.connection);
            cmd.Parameters.AddWithValue("@emp_id", employeeId);
            MySqlDataReader rdr = cmd.ExecuteReader();
            string type = "";
            rdr.Read();
            if (rdr.IsDBNull(0))
            {
                type = "";
            }
            else
            {
                type= rdr.GetString(0);
            }
          
            this.connection.Close();
            return type;
           

        }

        public bool isRegisteredEmployeeId(int employeeId)
        {
            this.connection.Open();
            string sql = "SELECT employee_id FROM fingerprints WHERE employee_id=@emp_id";
            MySqlCommand cmd = new MySqlCommand(sql, this.connection);
            cmd.Parameters.AddWithValue("@emp_id", employeeId);
            MySqlDataReader rdr = cmd.ExecuteReader();
            bool isRegistered = rdr.HasRows? true : false;
            this.connection.Close();
            return isRegistered;
          
        }


        public byte[] getFingerprint(int employeeId)
        {
            this.connection.Open();
            string sql = "SELECT fingerprint FROM fingerprints WHERE employee_id=@emp_id";
            MySqlCommand cmd = new MySqlCommand(sql, this.connection);
            cmd.Parameters.AddWithValue("@emp_id", employeeId);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
           
            byte[] fingerprint=(byte [])rdr["fingerprint"];


            this.connection.Close();
            return fingerprint;
        }
    }

}
