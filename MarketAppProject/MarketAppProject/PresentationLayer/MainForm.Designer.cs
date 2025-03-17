namespace MarketAppProject.PresentationLayer
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAdminLogin = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnCompanyOwnerLogin = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnUserLogin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(155, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To The Company App";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnAdminLogin);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 141);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin";
            // 
            // BtnAdminLogin
            // 
            this.BtnAdminLogin.BackColor = System.Drawing.Color.White;
            this.BtnAdminLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdminLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAdminLogin.Location = new System.Drawing.Point(3, 23);
            this.BtnAdminLogin.Name = "BtnAdminLogin";
            this.BtnAdminLogin.Size = new System.Drawing.Size(270, 115);
            this.BtnAdminLogin.TabIndex = 0;
            this.BtnAdminLogin.UseVisualStyleBackColor = false;
            this.BtnAdminLogin.Click += new System.EventHandler(this.BtnAdminEnter_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnCompanyOwnerLogin);
            this.groupBox2.Location = new System.Drawing.Point(294, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 141);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Company Owner";
            // 
            // BtnCompanyOwnerLogin
            // 
            this.BtnCompanyOwnerLogin.BackColor = System.Drawing.Color.White;
            this.BtnCompanyOwnerLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCompanyOwnerLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCompanyOwnerLogin.Location = new System.Drawing.Point(3, 23);
            this.BtnCompanyOwnerLogin.Name = "BtnCompanyOwnerLogin";
            this.BtnCompanyOwnerLogin.Size = new System.Drawing.Size(270, 115);
            this.BtnCompanyOwnerLogin.TabIndex = 1;
            this.BtnCompanyOwnerLogin.UseVisualStyleBackColor = false;
            this.BtnCompanyOwnerLogin.Click += new System.EventHandler(this.BtnUserEnter_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnUserLogin);
            this.groupBox3.Location = new System.Drawing.Point(576, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(276, 141);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "User";
            // 
            // BtnUserLogin
            // 
            this.BtnUserLogin.BackColor = System.Drawing.Color.White;
            this.BtnUserLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUserLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnUserLogin.Location = new System.Drawing.Point(3, 23);
            this.BtnUserLogin.Name = "BtnUserLogin";
            this.BtnUserLogin.Size = new System.Drawing.Size(270, 115);
            this.BtnUserLogin.TabIndex = 1;
            this.BtnUserLogin.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(882, 194);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnAdminLogin;
        private System.Windows.Forms.Button BtnCompanyOwnerLogin;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnUserLogin;
    }
}