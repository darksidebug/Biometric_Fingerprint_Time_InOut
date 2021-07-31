namespace CafeRomaraBiometric
{
    partial class DashboardForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fingerPrintRegistrationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeIdTxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.changeAuthKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10);
            this.menuStrip1.Size = new System.Drawing.Size(605, 39);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fingerPrintRegistrationMenuItem,
            this.changeAuthKeyToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.newToolStripMenuItem.Text = "File";
            // 
            // fingerPrintRegistrationMenuItem
            // 
            this.fingerPrintRegistrationMenuItem.Name = "fingerPrintRegistrationMenuItem";
            this.fingerPrintRegistrationMenuItem.Size = new System.Drawing.Size(201, 22);
            this.fingerPrintRegistrationMenuItem.Text = "Finger Print Registration";
            this.fingerPrintRegistrationMenuItem.Click += new System.EventHandler(this.fingerPrintRegistrationMenuItem_Click);
            // 
            // employeeIdTxtbox
            // 
            this.employeeIdTxtbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeeIdTxtbox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.employeeIdTxtbox.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIdTxtbox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.employeeIdTxtbox.Location = new System.Drawing.Point(108, 226);
            this.employeeIdTxtbox.MaxLength = 10;
            this.employeeIdTxtbox.Name = "employeeIdTxtbox";
            this.employeeIdTxtbox.Size = new System.Drawing.Size(379, 57);
            this.employeeIdTxtbox.TabIndex = 2;
            this.employeeIdTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.employeeIdTxtbox.TextChanged += new System.EventHandler(this.employeeIdTxtbox_TextChanged);
            this.employeeIdTxtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.employeeIdTxtbox_KeyDown);
            this.employeeIdTxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.employeeIdTxtbox_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(232, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Your Employee ID";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(94, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 86);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cafe Romara";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Location = new System.Drawing.Point(162, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 47);
            this.label3.TabIndex = 5;
            this.label3.Text = "Biometric System";
            // 
            // submitBtn
            // 
            this.submitBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submitBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.submitBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.submitBtn.Location = new System.Drawing.Point(107, 289);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(380, 51);
            this.submitBtn.TabIndex = 6;
            this.submitBtn.Text = "SUBMIT";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(107, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(380, 51);
            this.button1.TabIndex = 7;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // changeAuthKeyToolStripMenuItem
            // 
            this.changeAuthKeyToolStripMenuItem.Name = "changeAuthKeyToolStripMenuItem";
            this.changeAuthKeyToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.changeAuthKeyToolStripMenuItem.Text = "Change Auth Key";
            this.changeAuthKeyToolStripMenuItem.Click += new System.EventHandler(this.changeAuthKeyToolStripMenuItem_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(605, 422);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeeIdTxtbox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DashboardForm";
            this.Text = "Main Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fingerPrintRegistrationMenuItem;
        private System.Windows.Forms.TextBox employeeIdTxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem changeAuthKeyToolStripMenuItem;

    }
}

