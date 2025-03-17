namespace MarketAppProject.PresentationLayer
{
    partial class CompanyOwnerLoginForm
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
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.LblUsername = new System.Windows.Forms.Label();
            this.LLRegisterCompanyOwner = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Company Owner Log in Form";
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.Cyan;
            this.BtnLogin.Location = new System.Drawing.Point(156, 167);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(185, 40);
            this.BtnLogin.TabIndex = 10;
            this.BtnLogin.Text = "Log in";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(156, 134);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(185, 27);
            this.TxtPassword.TabIndex = 9;
            this.TxtPassword.Text = "12345678";
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(67, 134);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(79, 19);
            this.LblPassword.TabIndex = 8;
            this.LblPassword.Text = "Password:";
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(156, 97);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(185, 27);
            this.TxtUsername.TabIndex = 7;
            this.TxtUsername.Text = "TestCompanyOwner";
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Location = new System.Drawing.Point(67, 97);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(83, 19);
            this.LblUsername.TabIndex = 6;
            this.LblUsername.Text = "Username:";
            // 
            // LLRegisterCompanyOwner
            // 
            this.LLRegisterCompanyOwner.AutoSize = true;
            this.LLRegisterCompanyOwner.Location = new System.Drawing.Point(278, 210);
            this.LLRegisterCompanyOwner.Name = "LLRegisterCompanyOwner";
            this.LLRegisterCompanyOwner.Size = new System.Drawing.Size(192, 19);
            this.LLRegisterCompanyOwner.TabIndex = 12;
            this.LLRegisterCompanyOwner.TabStop = true;
            this.LLRegisterCompanyOwner.Text = "Don\'t you have an account?";
            // 
            // CompanyOwnerLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(482, 249);
            this.Controls.Add(this.LLRegisterCompanyOwner);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.LblUsername);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CompanyOwnerLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company Owner Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.LinkLabel LLRegisterCompanyOwner;
    }
}