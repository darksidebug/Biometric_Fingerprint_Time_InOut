using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRomaraBiometric
{
    class BaseDatabaseConnector:IDatabaseConnector
    {

        public IDatabaseConfig config { get; set; }
        public IConnStringBuilder builder { get; set; }
        protected string connectionString;
        public BaseDatabaseConnector(IDatabaseConfig config,IConnStringBuilder builder)
        {
            this.config = config;
            this.builder = builder;
            this.connectionString = builder.build(config);
        }
        public MySql.Data.MySqlClient.MySqlConnection connect()
        {
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(this.connectionString);
            return conn;
        }
    }
}
