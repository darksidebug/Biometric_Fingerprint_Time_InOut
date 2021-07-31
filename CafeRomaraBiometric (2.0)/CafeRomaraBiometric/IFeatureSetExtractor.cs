using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRomaraBiometric
{
    interface IFeatureSetExtractor
    {

        DPFP.FeatureSet extractFromSample(DPFP.Sample sample);
    }
}
