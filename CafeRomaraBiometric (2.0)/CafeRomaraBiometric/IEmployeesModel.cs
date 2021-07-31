using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRomaraBiometric
{
    interface IEmployeesModel
    {
        IEmployee getEmployeeById(int id);
        string getFullnameById(int employeeId);
    }
}
