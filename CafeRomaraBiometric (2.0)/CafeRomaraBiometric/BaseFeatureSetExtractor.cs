using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRomaraBiometric
{
    class BaseFeatureSetExtractor:IFeatureSetExtractor
    {

        public DPFP.FeatureSet extractFromSample(DPFP.Sample sample)
        {
            DPFP.Processing.FeatureExtraction extractor = new DPFP.Processing.FeatureExtraction();
            DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet featureSet = new DPFP.FeatureSet();
            extractor.CreateFeatureSet(sample, DPFP.Processing.DataPurpose.Verification, ref feedback, ref featureSet);
            if (feedback == DPFP.Capture.CaptureFeedback.Good)
                return featureSet;
            else
                return null;
        }
    }
}
