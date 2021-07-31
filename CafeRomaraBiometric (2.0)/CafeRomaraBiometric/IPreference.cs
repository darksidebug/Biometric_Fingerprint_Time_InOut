using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRomaraBiometric
{
    interface IPreference
    {

        int getMaxOt();
        float getNightDifferential();
        bool isBeyondMaxOt(double OtMinutes);
    }
}
