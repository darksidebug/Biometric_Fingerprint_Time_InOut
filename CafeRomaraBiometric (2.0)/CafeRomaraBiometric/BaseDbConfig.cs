using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRomaraBiometric
{
    class BaseDbConfig:IDatabaseConfig
    {
        protected string server = "localhost";
        protected string username = "root";
        protected string dbName = "";
        protected string password = "";

        public virtual string getServer()
        {
            return server;
        }

        public virtual string getUser()
        {
            return username;
        }

        public virtual string getDBName()
        {
            return dbName;
        }

        public virtual string getPassword()
        {
            return password;
        }
    }
}
