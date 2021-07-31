using DPFP;
using DPFP.Capture;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeRomaraBiometric
{
    public partial class DashboardForm : Form
    {

        private BaseFingerprintsModel fingerprintsModel;
       

        public DashboardForm()
        {
            InitializeComponent();
            BaseDatabaseConnector connector = new BaseDatabaseConnector(new LocalDbConfig(),new BaseConnStringBuilder());
            this.fingerprintsModel = new BaseFingerprintsModel(connector.connect());
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
         
        }
       
        public bool ByteArrayToFile(string fileName, byte[] byteArray)
        {
            try
            {
                using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    fs.Write(byteArray, 0, byteArray.Length);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in process: {0}", ex);
                return false;
            }
        }
   
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void fingerPrintRegistrationMenuItem_Click(object sender, EventArgs e)
        {
            AuthorizationForm authForm = new AuthorizationForm("registration");
            authForm.ShowDialog();
            
        }

        private void employeeIdTxtbox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void employeeIdTxtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                submitBtn.PerformClick();
            }
        }

        private void employeeIdTxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employeeIdTxtbox.Text = "";
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            int employeeId = int.Parse(employeeIdTxtbox.Text);
    
            if (this.fingerprintsModel.isRegisteredEmployeeId(employeeId))
            {
                TimeinForm timeinForm = new TimeinForm(employeeId);
                timeinForm.ShowDialog();
            }
            else
            {
                MessageBoxOutputer.simpleWarningMessage("Employee's fingerprint is not registered yet", "Fingerprint Error");
            }
        }

        private void changeAuthKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorizationForm authForm = new AuthorizationForm("change_pass");
            authForm.ShowDialog();
        }
    }
}
