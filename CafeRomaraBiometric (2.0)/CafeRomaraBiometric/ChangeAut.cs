using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace CafeRomaraBiometric
{
    public partial class ChangeAut : Form
    {
        public ChangeAut()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

  
            TextWriter textWriter = new StreamWriter(@"..\..\AuthKey.txt");
            string newAuth="auth_key="+passTxtBox.Text;
            textWriter.Write(newAuth);
            textWriter.Close();
            MessageBoxOutputer.simpleSuccessMessage("Authentication Key Updated", "Auth Key");
            this.Close();
        }

        private void passTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                changeBtn.PerformClick();
            }
        }
    }
}
