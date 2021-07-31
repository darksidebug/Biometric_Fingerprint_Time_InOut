using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRomaraBiometric
{
    class Accountant
    {

        public bool isLate(DateTime scheduledTime, DateTime actualTime)
        {
            TimeSpan span = scheduledTime.Subtract(actualTime);
              double minsLate=span.TotalMinutes;

              if (minsLate > 0)
              {
                  return true;
              }
              return false;
        }

        public double calculateHours(string strTime1, string strTime2)
        {
           DateTime time1= StrTimeParser.parse(strTime1);
           DateTime time2 = StrTimeParser.parse(strTime2);
           TimeSpan timeSpan = time1 - time2;
           return timeSpan.TotalHours;
        }
        


    }
}
