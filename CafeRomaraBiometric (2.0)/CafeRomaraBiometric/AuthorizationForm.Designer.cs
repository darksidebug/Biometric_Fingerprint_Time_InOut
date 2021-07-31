namespace CafeRomaraBiometric
{
    partial class AuthorizationForm
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
            this.authKeyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.authorizeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authKeyTextBox
            // 
            this.authKeyTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authKeyTextBox.Location = new System.Drawing.Point(40, 53);
            this.authKeyTextBox.Name = "authKeyTextBox";
            this.authKeyTextBox.PasswordChar = '*';
            this.authKeyTextBox.Size = new System.Drawing.Size(257, 35);
            this.authKeyTextBox.TabIndex = 0;
            this.authKeyTextBox.TextChanged += new System.EventHandler(this.authKeyTextBox_TextChanged);
            this.authKeyTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.authKeyTextBox_KeyDown);
            this.authKeyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.authKeyTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Authorization Key";
            // 
            // authorizeBtn
            // 
            this.authorizeBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.authorizeBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.authorizeBtn.Location = new System.Drawing.Point(303, 53);
            this.authorizeBtn.Name = "authorizeBtn";
            this.authorizeBtn.Size = new System.Drawing.Size(79, 35);
            this.authorizeBtn.TabIndex = 2;
            this.authorizeBtn.Text = "Authorize";
            this.authorizeBtn.UseVisualStyleBackColor = false;
            this.authorizeBtn.Click += new System.EventHandler(this.authorizeBtn_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(421, 131);
            this.Controls.Add(this.authorizeBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.authKeyTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Authorization Required";
            this.Load += new System.EventHandler(this.AuthorizationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox authKeyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button authorizeBtn;
    }
}