using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRomaraBiometric
{
    class BaseConnStringBuilder:IConnStringBuilder
    {
        public string build(IDatabaseConfig config)
        {
            string connectionString = "server=" + config.getServer() + ";user=" + config.getUser() + ";database=" + config.getDBName() + ";port=3306;password=" + config.getPassword();
            return connectionString;
        }
    }
}
