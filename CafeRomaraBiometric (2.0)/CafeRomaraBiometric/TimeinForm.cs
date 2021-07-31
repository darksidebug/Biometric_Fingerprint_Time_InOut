using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeRomaraBiometric
{
    public partial class TimeinForm : Form,DPFP.Capture.EventHandler
    {

        public int employeeId;
        private MySql.Data.MySqlClient.MySqlConnection connection;
        private DPFP.Capture.Capture capturer;
        private BaseFeatureSetExtractor featureSetExtractor;
        private BaseFingerprintsModel fingerprintsModel;
        int PROBABILITY_ONE = 0x7FFFFFFF;
        private TimeLogger timeLogger;


        //DELEGATES
        private delegate void CloseWindowDelegate();


        public TimeinForm(int employeeId)
        {
          
            InitializeComponent();
            this.employeeId = employeeId;
            BaseDatabaseConnector connector = new BaseDatabaseConnector(new LocalDbConfig(), new BaseConnStringBuilder());

            this.connection = connector.connect();
            this.capturer = new DPFP.Capture.Capture();
            this.capturer.EventHandler = this;
            this.featureSetExtractor = new BaseFeatureSetExtractor();
            this.fingerprintsModel = new BaseFingerprintsModel(this.connection);
            this.timeLogger = new TimeLogger(this.connection,new TimeCalculator(),new EmployeeModel(this.connection));
           
        }

        private void closeWindow()
        {
            if (this.InvokeRequired)
            {
                var d = new CloseWindowDelegate(closeWindow);
                this.Invoke(d);
            }
            else
            {
                this.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TimeinForm_Load(object sender, EventArgs e)
        {

         
            employeeIdLbl.Text = this.employeeId.ToString();
            BaseEmployeeModel employeeModel = new BaseEmployeeModel(this.connection);
            string fullname=employeeModel.getFullnameById(employeeId);
            fullnameLbl.Text = fullname;

            this.capturer.StartCapture();

            
        }

        private Bitmap convertToBitmap(DPFP.Sample sample)
        {
            DPFP.Capture.SampleConversion converter = new DPFP.Capture.SampleConversion();
            Bitmap bitmap = null;
            converter.ConvertToPicture(sample, ref bitmap);
            return bitmap;
        }

        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample)
        {

            DPFP.FeatureSet featureSet=this.featureSetExtractor.extractFromSample(Sample);
            DPFP.Verification.Verification verifier = new DPFP.Verification.Verification();
            verifier.FARRequested = PROBABILITY_ONE / 1000000;
            byte[] fingerData = this.fingerprintsModel.getFingerprint(employeeId);
            System.IO.Stream stream = new System.IO.MemoryStream(fingerData);
            DPFP.Template template=new DPFP.Template(stream);

            fingerPictureBox.BackgroundImage = this.convertToBitmap(Sample);

            DPFP.Verification.Verification.Result verificationResult=new DPFP.Verification.Verification.Result();
            if (featureSet != null)
            {
                try
                {
                
                    verifier.Verify(featureSet, template, ref verificationResult);

                    if (verificationResult.Verified)
                    {
                        IPreferenceRepository preferenceRepo=new PreferenceRepository(this.connection);
                        IPreference prefence=new Preference(preferenceRepo);

                        timeLogger.setPreference(prefence);
                        timeLogger.setFingerModel(new BaseFingerprintsModel(this.connection));

                       bool logResult= this.timeLogger.log(this.employeeId,new TimeLogModel(this.connection));

                       if (logResult)
                       {
                           MessageBoxOutputer.simpleSuccessMessage("Time saved. Thank you!","Clock In");
                           
                       }
                       else
                       {
                           MessageBoxOutputer.simpleWarningMessage("You're done with your work day.","Clock In Error");
                          
                       }
                    }
                    else
                    {
                        MessageBoxOutputer.simpleErrorMessage("Unknown fingerprint. Please try again!","Clock In Error");
                    }
                }
                catch (Exception e)
                {
                    
                    MessageBox.Show(e.Message);
                    
                }

            }
            else
            {
                MessageBox.Show("No featureset");
            }

           
            this.capturer.StopCapture();
            closeWindow();


        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
           
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
           
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback)
        {
            
        }
    }
}
