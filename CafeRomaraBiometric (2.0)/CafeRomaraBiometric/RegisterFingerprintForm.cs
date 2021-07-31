using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DPFP;
namespace CafeRomaraBiometric
{
    public partial class RegisterFingerprintForm : Form, DPFP.Capture.EventHandler
    {
        private delegate void DefaultModeCallback();
       
        private delegate void ResetVerificationCallback();
        protected MySql.Data.MySqlClient.MySqlConnection conn;
        private BaseEmployeeModel employeeModel;
        private DPFP.Capture.Capture capturer;
        private BaseFingerRegistrar fingerRegistrar;
        private bool isVerifiedEmployeeId;
        private bool hasRegisteredAlready;
        private BaseFingerprintsModel fingerprintModel;
        private int verifiedEmployeeId;
        private string accountType = "Normal";
        public RegisterFingerprintForm()
        {
            InitializeComponent();
            BaseDbConfig config = new LocalDbConfig();
            BaseDatabaseConnector connector = new BaseDatabaseConnector(config, new BaseConnStringBuilder());

            this.conn = connector.connect();
            this.employeeModel = new BaseEmployeeModel(this.conn);
            this.capturer = new DPFP.Capture.Capture();
            this.fingerRegistrar = new BaseFingerRegistrar();
            this.fingerprintModel = new BaseFingerprintsModel(this.conn);
        }

        private void RegisterFingerprintForm_Load(object sender, EventArgs e)
        {
            
          
        }

        private void ToResetVerification()
        {

            if (this.verificationBox.InvokeRequired && this.employeeIdTxtBox.InvokeRequired && this.scanFingerBtn.InvokeRequired)
            {
                ResetVerificationCallback d = new ResetVerificationCallback(ToResetVerification);
                this.Invoke(d);

            }
            else
            {
                this.resetVerification();
            }
        }

        private void ToDefaultMode()
        {

            if (this.scanFingerBtn.InvokeRequired)
            {
                DefaultModeCallback d = new DefaultModeCallback(ToDefaultMode);
                this.Invoke(d);
               
            }
            else
            {
                this.defaultMode();
            }
        }

        private void verifyEmployeeId()
        {
            int employeeId=0;
            try
            {
                employeeId = int.Parse(employeeIdTxtBox.Text);
            }
            catch (Exception e)
            {
                //not do anything
            }

            IEmployee employee = this.employeeModel.getEmployeeById(employeeId);

         
             this.isVerifiedEmployeeId = employee != null;
             this.hasRegisteredAlready = this.fingerprintModel.isRegisteredEmployeeId(employeeId);
       
          
        }

        private void outputVerificationResult()
        {
            if (hasRegisteredAlready)
            {
                MessageBox.Show("Employee has already registered a fingerprint", "Error");
            }
            if (!this.isVerifiedEmployeeId)
            {
                MessageBox.Show("Unknown Employee ID", "Employee Verification");
            }

          
        }

        private void enableScanWhenVerified()
        {
                bool shouldAllowScan=this.isVerifiedEmployeeId && !this.hasRegisteredAlready;
                scanFingerBtn.Enabled =shouldAllowScan ;
          
        }

        private void enableAccountTypeSelectionWhenVerified()
        {
            bool allow = this.isVerifiedEmployeeId && !this.hasRegisteredAlready;
            typeComboBox.Enabled = allow;
        }

        private void disableEmpVerificationWhenVerified()
        {
            if (this.isVerifiedEmployeeId && !this.hasRegisteredAlready)
            {
                verificationBox.Enabled = false;
            }
            else 
            {
                verificationBox.Enabled = true;
            }
      
        }
        private void resetVerification()
        {
            verificationBox.Enabled = true;
            employeeIdTxtBox.Text = "";
            scanFingerBtn.Enabled = false;

        }

        private void initVerication()
        {
            this.verifyEmployeeId();
            this.outputVerificationResult();
            this.enableScanWhenVerified();
            this.enableAccountTypeSelectionWhenVerified();
            this.disableEmpVerificationWhenVerified();
            this.setEmployeeIdWhenVerified();
        }

        private void checkEmpIdBtn_Click(object sender, EventArgs e)
        {
          
            this.initVerication();
           
        }

        private void setEmployeeIdWhenVerified()
        {
            if (this.isVerifiedEmployeeId && !this.hasRegisteredAlready)
            {
                this.verifiedEmployeeId = int.Parse(employeeIdTxtBox.Text);
            }
        }

        private void employeeIdTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.initVerication();
            }
           
        }

        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample)
        {
            Template template= this.fingerRegistrar.processRegistration(Sample);

            ToDefaultMode();
            if (template != null)
            {
                ToResetVerification();
                try
                {
                    this.fingerprintModel.insert(this.verifiedEmployeeId, template, this.accountType);

                }
                catch (Exception e)
                {
                    MessageBoxOutputer.simpleErrorMessage(e.Message, "Error");
                }
               
                MessageBox.Show("Great! Fingerprint captured.", "Fingerprint Registration");
            }
            else
            {
                MessageBox.Show("Scan again for better accuracy", "Fingerprint Registration");
                
            }
           
            this.capturer.StopCapture();
           
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void scanningMode()
        {
            scanFingerBtn.Text = "Scanning a finger";
            scanFingerBtn.Enabled = false;
        }
        private void defaultMode()
        {
          
            scanFingerBtn.Text = "Scan a finger";
            scanFingerBtn.Enabled = true;
        }

        private void scanFingerBtn_Click(object sender, EventArgs e)
        {

            try
            {
                this.capturer.StartCapture();
                this.capturer.EventHandler = this;
                this.scanningMode();
            }
            catch 
            {}
           
        }

        private void employeeIdTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                employeeIdTxtBox.Text = "";
            }
           
            e.Handled = !char.IsDigit(e.KeyChar);   
        }

        private void employeeIdTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.accountType = typeComboBox.Text;
        }

        
    }
}
