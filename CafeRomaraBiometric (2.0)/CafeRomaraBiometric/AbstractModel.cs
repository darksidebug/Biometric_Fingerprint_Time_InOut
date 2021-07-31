using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace CafeRomaraBiometric
{
    class AbstractModel
    {
        protected  MySqlConnection connection;

          public AbstractModel(MySqlConnection connection)
        {
            this.connection = connection;
        }
    }
}
