using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace CafeRomaraBiometric
{
    class PreferenceRepository:IPreferenceRepository
    {
   
        private MySql.Data.MySqlClient.MySqlConnection connection;

        public PreferenceRepository(MySqlConnection connection)
        {
            this.connection =connection;
        }

        private MySqlDataReader performRead(string colName)
        {
            string sql = "SELECT "+colName+" FROM preferences LIMIT 1";
            MySqlCommand command = new MySqlCommand(sql, this.connection);
            MySqlDataReader reader = command.ExecuteReader();
            return reader;
        }
  
        public int getMaxOt()
        {
            this.connection.Open();
            MySqlDataReader reader = this.performRead("max_ot");
            reader.Read();
            int maxOt=0;
            if (!reader.IsDBNull(0))
            {
                maxOt = reader.GetInt32(0);
            }
   
            this.connection.Close();

            return maxOt;
            
        }

        public float getNightDifferential()
        {
            this.connection.Open();
            MySqlDataReader reader = this.performRead("night_dif");
            reader.Read();
            float nightDif = 0;
            if (!reader.IsDBNull(0))
            {
                nightDif = reader.GetFloat(0);
            }

            this.connection.Close();

            return nightDif;
           
        }
    }
}
