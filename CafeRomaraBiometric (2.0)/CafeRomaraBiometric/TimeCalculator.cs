using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRomaraBiometric
{
    class TimeCalculator
    {

        public double minsDifference(DateTime startTime, DateTime endTime)
        {
            TimeSpan span = endTime.Subtract(startTime);
            return span.TotalMinutes;
        }

        public double zeroOrMinsDifference(DateTime startTime, DateTime endTime)
        {
            double difference=this.minsDifference(startTime, endTime);
            if (difference < 0) return 0;
            return difference;
        }

        public string strTimeAddMinutes(string time,int minutes)
        {
            DateTime parsedTime=StrTimeParser.parse(time);
            DateTime addedMinutes=parsedTime.AddMinutes((double)minutes);
            return addedMinutes.ToString("HH:mm:ss");
        }



    }
}
