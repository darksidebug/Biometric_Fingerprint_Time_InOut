using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRomaraBiometric
{
    interface IFingerprintsModel
    {
        void insert(int employeeId, DPFP.Template fingerprintTemplate,string type);
        bool isRegisteredEmployeeId(int employeeId);
        byte [] getFingerprint(int employeeId);
        string getTypeById(int employeeId);
    }
}
