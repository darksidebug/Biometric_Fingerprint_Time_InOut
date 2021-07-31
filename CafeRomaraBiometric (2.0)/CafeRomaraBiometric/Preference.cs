using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRomaraBiometric
{
    class Preference:IPreference
    {
        private IPreferenceRepository repository;

        public Preference(IPreferenceRepository repository)
        {
            this.repository = repository;
        }

        public int getMaxOt()
        {
            return this.repository.getMaxOt();
        }

        public float getNightDifferential()
        {
            return this.repository.getNightDifferential();
        }

        public bool isBeyondMaxOt(double OtMinutes)
        {
            return OtMinutes > this.repository.getMaxOt();
        }
    }
}
