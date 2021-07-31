using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRomaraBiometric
{
    class BaseEmployee:IEmployee
    {

        protected int id;
        protected string firstname;
        protected string middlename;
        protected string lastname;
        protected string suffix;
        protected string timeIn;
        protected string timeOut;
        protected int breakMins;

        public BaseEmployee(IDictionary<string, string> employeeInfo)
        {
            this.id=int.Parse(employeeInfo["id"]);
            this.firstname=employeeInfo["firstname"];
            this.middlename = employeeInfo["middlename"];
            this.lastname = employeeInfo["lastname"];
            this.suffix = employeeInfo["suffix"];
            this.timeIn = employeeInfo["time_in"];
            this.timeOut = employeeInfo["time_out"];
          

        }


        public int getId()
        {
            return id;
        }

        public string getMiddlename()
        {
            return middlename;
        }

        public string getLastname()
        {
            return lastname;
        }

        public string getSuffix()
        {
            return suffix;
        }

        public string getTimeIn()
        {
            return timeIn;
        }

        public string getTimeOut()
        {
            return timeOut;
        }

        public int getBreakMins()
        {
            return breakMins;
        }


        public string getFirstname()
        {
            return firstname;
        }
    }
}
