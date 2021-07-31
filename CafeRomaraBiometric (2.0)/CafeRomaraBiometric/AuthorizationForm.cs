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
    public partial class AuthorizationForm : Form
    {

        private string authKey;
        private string intended;
        public AuthorizationForm(string intended)
        {
            InitializeComponent();

            string text = System.IO.File.ReadAllText(@"..\..\AuthKey.txt");

           string[] splittedText= text.Split('=');
           this.authKey = splittedText[1];
           this.intended = intended;
        
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {

        }

        private void authorizeBtn_Click(object sender, EventArgs e)
        {
            string inputtedKey = authKeyTextBox.Text;
            if (inputtedKey == this.authKey)
            {
                this.Close();
               
                if (this.intended == "registration")
                {
                    RegisterFingerprintForm registerForm = new RegisterFingerprintForm();

                    registerForm.ShowDialog();
                }
                else if(this.intended=="change_pass")
                {
                    ChangeAut changeAuth = new ChangeAut();
                    changeAuth.ShowDialog();
                }
                
               
            }
            else
            {
               
                MessageBoxOutputer.simpleErrorMessage("Authorization Key is incorrect", "Authorization Error");
                authKeyTextBox.Text = "";
                authKeyTextBox.Focus();
            }
        }

        private void authKeyTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void authKeyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void authKeyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                authorizeBtn.PerformClick();
            }
        }
    }
}
