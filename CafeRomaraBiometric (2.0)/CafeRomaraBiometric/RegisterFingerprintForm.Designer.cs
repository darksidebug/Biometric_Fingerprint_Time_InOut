namespace CafeRomaraBiometric
{
    partial class RegisterFingerprintForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.employeeIdTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkEmpIdBtn = new System.Windows.Forms.Button();
            this.verificationBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.scanFingerBtn = new System.Windows.Forms.Button();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.verificationBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeIdTxtBox
            // 
            this.employeeIdTxtBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIdTxtBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.employeeIdTxtBox.Location = new System.Drawing.Point(52, 53);
            this.employeeIdTxtBox.MaxLength = 10;
            this.employeeIdTxtBox.Name = "employeeIdTxtBox";
            this.employeeIdTxtBox.Size = new System.Drawing.Size(233, 33);
            this.employeeIdTxtBox.TabIndex = 0;
            this.employeeIdTxtBox.TextChanged += new System.EventHandler(this.employeeIdTxtBox_TextChanged);
            this.employeeIdTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.employeeIdTxtBox_KeyDown);
            this.employeeIdTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.employeeIdTxtBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee ID";
            // 
            // checkEmpIdBtn
            // 
            this.checkEmpIdBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.checkEmpIdBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkEmpIdBtn.Location = new System.Drawing.Point(291, 47);
            this.checkEmpIdBtn.Name = "checkEmpIdBtn";
            this.checkEmpIdBtn.Size = new System.Drawing.Size(100, 42);
            this.checkEmpIdBtn.TabIndex = 2;
            this.checkEmpIdBtn.Text = "VERIFY";
            this.checkEmpIdBtn.UseVisualStyleBackColor = false;
            this.checkEmpIdBtn.Click += new System.EventHandler(this.checkEmpIdBtn_Click);
            // 
            // verificationBox
            // 
            this.verificationBox.Controls.Add(this.label2);
            this.verificationBox.Controls.Add(this.checkEmpIdBtn);
            this.verificationBox.Controls.Add(this.employeeIdTxtBox);
            this.verificationBox.Controls.Add(this.label1);
            this.verificationBox.Location = new System.Drawing.Point(40, 22);
            this.verificationBox.Name = "verificationBox";
            this.verificationBox.Size = new System.Drawing.Size(426, 127);
            this.verificationBox.TabIndex = 3;
            this.verificationBox.TabStop = false;
            this.verificationBox.Text = "Verification";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(50, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter a valid employee ID to start registration";
            // 
            // scanFingerBtn
            // 
            this.scanFingerBtn.Enabled = false;
            this.scanFingerBtn.Location = new System.Drawing.Point(18, 82);
            this.scanFingerBtn.Name = "scanFingerBtn";
            this.scanFingerBtn.Size = new System.Drawing.Size(391, 35);
            this.scanFingerBtn.TabIndex = 3;
            this.scanFingerBtn.Text = "Scan a Finger";
            this.scanFingerBtn.UseVisualStyleBackColor = false;
            this.scanFingerBtn.Click += new System.EventHandler(this.scanFingerBtn_Click);
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.Enabled = false;
            this.typeComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Special",
            "Normal"});
            this.typeComboBox.Location = new System.Drawing.Point(18, 43);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(391, 29);
            this.typeComboBox.TabIndex = 4;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.typeComboBox);
            this.groupBox1.Controls.Add(this.scanFingerBtn);
            this.groupBox1.Location = new System.Drawing.Point(40, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 144);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Account Type";
            // 
            // RegisterFingerprintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(504, 326);
            this.Controls.Add(this.verificationBox);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RegisterFingerprintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Register Fingerprint";
            this.Load += new System.EventHandler(this.RegisterFingerprintForm_Load);
            this.verificationBox.ResumeLayout(false);
            this.verificationBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox employeeIdTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button checkEmpIdBtn;
        private System.Windows.Forms.GroupBox verificationBox;
        private System.Windows.Forms.Button scanFingerBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
    }
}