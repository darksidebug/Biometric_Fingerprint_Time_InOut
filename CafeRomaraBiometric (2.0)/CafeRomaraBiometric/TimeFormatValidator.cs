using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRomaraBiometric
{
    class TimeFormatValidator
    {
        public bool validate(string time)
        {
            try
            {

                DateTime parsedTime = DateTime.ParseExact(time, "HH:mm:ss", System.Globalization.CultureInfo.CurrentCulture);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public void throwInvalidFormat()
        {
            throw new Exception("Invalid time format");
        }
    }
}
