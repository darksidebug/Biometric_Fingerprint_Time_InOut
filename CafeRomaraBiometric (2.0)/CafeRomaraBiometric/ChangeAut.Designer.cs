namespace CafeRomaraBiometric
{
    partial class ChangeAut
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
            this.passTxtBox = new System.Windows.Forms.TextBox();
            this.changeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passTxtBox
            // 
            this.passTxtBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTxtBox.Location = new System.Drawing.Point(28, 52);
            this.passTxtBox.Name = "passTxtBox";
            this.passTxtBox.PasswordChar = '*';
            this.passTxtBox.Size = new System.Drawing.Size(270, 33);
            this.passTxtBox.TabIndex = 0;
            this.passTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passTxtBox_KeyDown);
            // 
            // changeBtn
            // 
            this.changeBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.changeBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.changeBtn.Location = new System.Drawing.Point(304, 52);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(75, 33);
            this.changeBtn.TabIndex = 1;
            this.changeBtn.Text = "Change";
            this.changeBtn.UseVisualStyleBackColor = false;
            this.changeBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "New Auth Key";
            // 
            // ChangeAut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(410, 141);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.passTxtBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ChangeAut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change Auth key";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passTxtBox;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.Label label1;
    }
}