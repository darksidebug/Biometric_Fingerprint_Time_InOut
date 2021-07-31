using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPFP;
namespace CafeRomaraBiometric
{
    class BaseFingerRegistrar:IFingerRegistrar
    {

        protected DPFP.Processing.Enrollment enroller;


        public BaseFingerRegistrar()
        {
            this.enroller = new DPFP.Processing.Enrollment();
        }

        private FeatureSet extractFeatureSet(Sample sample)
        {
            DPFP.Processing.FeatureExtraction extractor = new DPFP.Processing.FeatureExtraction();
            DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet featureSet = new DPFP.FeatureSet();
            extractor.CreateFeatureSet(sample, DPFP.Processing.DataPurpose.Enrollment, ref feedback, ref featureSet);
            if (feedback == DPFP.Capture.CaptureFeedback.Good)
                return featureSet;
            else
                return null;
        }

     


        public Template processRegistration(DPFP.Sample sample)
        {
           Template templateResult=new Template();
            FeatureSet featureSet = this.extractFeatureSet(sample);

            if (featureSet != null)
            {
                try
                {
                    this.enroller.AddFeatures(featureSet);
                }
                finally 
                {
                    if (enroller.TemplateStatus == DPFP.Processing.Enrollment.Status.Ready)
                    {

                        templateResult= enroller.Template;
                        enroller.Clear();
                    }
                    else
                    {
                        templateResult= null;
                    }
                }
            }
            return templateResult;
        }
    }
}
