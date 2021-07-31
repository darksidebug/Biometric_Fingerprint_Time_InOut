using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRomaraBiometric
{
    class StrTimeParser
    {
        public static DateTime parse(string time)
        {
            DateTime parsedTime = DateTime.ParseExact(time, "HH:mm:ss", System.Globalization.CultureInfo.CurrentCulture);
            return parsedTime;
        }

        public static string parseToStr(DateTime time)
        {
            return time.ToString("HH:mm:ss");
        }

    }
}
