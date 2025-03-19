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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAdminLogin = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnCompanyOwner = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnUserLogin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.BtnAdminLogin);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin Login";
            // 
            // BtnAdminLogin
            // 
            this.BtnAdminLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnAdminLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAdminLogin.BackgroundImage")));
            this.BtnAdminLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAdminLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdminLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAdminLogin.Location = new System.Drawing.Point(3, 23);
            this.BtnAdminLogin.Name = "BtnAdminLogin";
            this.BtnAdminLogin.Size = new System.Drawing.Size(199, 124);
            this.BtnAdminLogin.TabIndex = 1;
            this.BtnAdminLogin.UseVisualStyleBackColor = false;
            this.BtnAdminLogin.Click += new System.EventHandler(this.BtnAdminLogin_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.BtnCompanyOwner);
            this.groupBox2.Location = new System.Drawing.Point(220, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 150);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Company Owner Login";
            // 
            // BtnCompanyOwner
            // 
            this.BtnCompanyOwner.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnCompanyOwner.BackgroundImage = global::MarketAppProject.Properties.Resources.companyOwnerIcon;
            this.BtnCompanyOwner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCompanyOwner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCompanyOwner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCompanyOwner.Location = new System.Drawing.Point(3, 23);
            this.BtnCompanyOwner.Name = "BtnCompanyOwner";
            this.BtnCompanyOwner.Size = new System.Drawing.Size(199, 124);
            this.BtnCompanyOwner.TabIndex = 1;
            this.BtnCompanyOwner.UseVisualStyleBackColor = false;
            this.BtnCompanyOwner.Click += new System.EventHandler(this.BtnCompanyOwner_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.BtnUserLogin);
            this.groupBox3.Location = new System.Drawing.Point(431, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(205, 150);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "User Login";
            // 
            // BtnUserLogin
            // 
            this.BtnUserLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnUserLogin.BackgroundImage = global::MarketAppProject.Properties.Resources.userIcon;
            this.BtnUserLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnUserLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUserLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnUserLogin.Location = new System.Drawing.Point(3, 23);
            this.BtnUserLogin.Name = "BtnUserLogin";
            this.BtnUserLogin.Size = new System.Drawing.Size(199, 124);
            this.BtnUserLogin.TabIndex = 1;
            this.BtnUserLogin.UseVisualStyleBackColor = false;
            this.BtnUserLogin.Click += new System.EventHandler(this.BtnUserLogin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(657, 192);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnAdminLogin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnCompanyOwner;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnUserLogin;
    }
}