using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRomaraBiometric
{
    class LocalDbConfig:BaseDbConfig
    {
        public override string getServer()
        {
            return "localhost";
        }

        public override string getUser()
        {
            return "root";
        }

        public override string getDBName()
        {
            return "cafe_romara_payroll";
        }

        public override string getPassword()
        {
            return "";
        }


    }
}
