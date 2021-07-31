namespace CafeRomaraBiometric
{
    partial class TimeinForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.employeeIdLbl = new System.Windows.Forms.Label();
            this.fingerPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fullnameLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.fingerPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(113, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // employeeIdLbl
            // 
            this.employeeIdLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeIdLbl.AutoSize = true;
            this.employeeIdLbl.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIdLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.employeeIdLbl.Location = new System.Drawing.Point(96, 66);
            this.employeeIdLbl.Name = "employeeIdLbl";
            this.employeeIdLbl.Size = new System.Drawing.Size(106, 50);
            this.employeeIdLbl.TabIndex = 1;
            this.employeeIdLbl.Text = "1001";
            this.employeeIdLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // fingerPictureBox
            // 
            this.fingerPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fingerPictureBox.Location = new System.Drawing.Point(20, 34);
            this.fingerPictureBox.Name = "fingerPictureBox";
            this.fingerPictureBox.Size = new System.Drawing.Size(179, 177);
            this.fingerPictureBox.TabIndex = 4;
            this.fingerPictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.fullnameLbl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.employeeIdLbl);
            this.groupBox1.Location = new System.Drawing.Point(27, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 230);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(123, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fullname";
            // 
            // fullnameLbl
            // 
            this.fullnameLbl.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullnameLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.fullnameLbl.Location = new System.Drawing.Point(6, 139);
            this.fullnameLbl.Name = "fullnameLbl";
            this.fullnameLbl.Size = new System.Drawing.Size(289, 37);
            this.fullnameLbl.TabIndex = 3;
            this.fullnameLbl.Text = "--";
            this.fullnameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fingerPictureBox);
            this.groupBox2.Location = new System.Drawing.Point(350, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 230);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Scan your finger";
            // 
            // TimeinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(598, 283);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TimeinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Scan your finger";
            this.Load += new System.EventHandler(this.TimeinForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fingerPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label employeeIdLbl;
        private System.Windows.Forms.PictureBox fingerPictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label fullnameLbl;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}