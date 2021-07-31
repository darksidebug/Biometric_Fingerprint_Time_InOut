using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRomaraBiometric
{
    interface IDatabaseConfig
    {

         string getServer();
         string getUser();
         string getDBName();
         string getPassword();

    }
}
