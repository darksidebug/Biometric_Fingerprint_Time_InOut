using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRomaraBiometric
{
    interface IEmployee
    {

        int getId();
        string getFirstname();
        string getMiddlename();
        string getLastname();
        string getSuffix();
        string getTimeIn();
        string getTimeOut();
        int getBreakMins();
    }
}
