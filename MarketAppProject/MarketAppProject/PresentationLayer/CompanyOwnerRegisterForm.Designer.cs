namespace MarketAppProject.PresentationLayer
{
    partial class CompanyOwnerRegisterForm
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
            this.BtnRegister = new System.Windows.Forms.Button();
            this.RTBAddress = new System.Windows.Forms.RichTextBox();
            this.RTBBirthPlace = new System.Windows.Forms.RichTextBox();
            this.CMBProfession = new System.Windows.Forms.ComboBox();
            this.DTPBirthDate = new System.Windows.Forms.DateTimePicker();
            this.RBFemale = new System.Windows.Forms.RadioButton();
            this.RBMale = new System.Windows.Forms.RadioButton();
            this.MTBPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtIdentityNumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnRegister
            // 
            this.BtnRegister.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnRegister.Location = new System.Drawing.Point(411, 431);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(280, 57);
            this.BtnRegister.TabIndex = 47;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = false;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // RTBAddress
            // 
            this.RTBAddress.Location = new System.Drawing.Point(480, 330);
            this.RTBAddress.Name = "RTBAddress";
            this.RTBAddress.Size = new System.Drawing.Size(364, 60);
            this.RTBAddress.TabIndex = 46;
            this.RTBAddress.Text = "";
            // 
            // RTBBirthPlace
            // 
            this.RTBBirthPlace.Location = new System.Drawing.Point(479, 250);
            this.RTBBirthPlace.Name = "RTBBirthPlace";
            this.RTBBirthPlace.Size = new System.Drawing.Size(364, 60);
            this.RTBBirthPlace.TabIndex = 45;
            this.RTBBirthPlace.Text = "";
            // 
            // CMBProfession
            // 
            this.CMBProfession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBProfession.FormattingEnabled = true;
            this.CMBProfession.Location = new System.Drawing.Point(480, 178);
            this.CMBProfession.Name = "CMBProfession";
            this.CMBProfession.Size = new System.Drawing.Size(173, 27);
            this.CMBProfession.TabIndex = 44;
            // 
            // DTPBirthDate
            // 
            this.DTPBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPBirthDate.Location = new System.Drawing.Point(480, 111);
            this.DTPBirthDate.Name = "DTPBirthDate";
            this.DTPBirthDate.Size = new System.Drawing.Size(173, 27);
            this.DTPBirthDate.TabIndex = 43;
            // 
            // RBFemale
            // 
            this.RBFemale.AutoSize = true;
            this.RBFemale.Location = new System.Drawing.Point(573, 52);
            this.RBFemale.Name = "RBFemale";
            this.RBFemale.Size = new System.Drawing.Size(80, 23);
            this.RBFemale.TabIndex = 42;
            this.RBFemale.Text = "Female";
            this.RBFemale.UseVisualStyleBackColor = true;
            // 
            // RBMale
            // 
            this.RBMale.AutoSize = true;
            this.RBMale.Checked = true;
            this.RBMale.Location = new System.Drawing.Point(480, 52);
            this.RBMale.Name = "RBMale";
            this.RBMale.Size = new System.Drawing.Size(65, 23);
            this.RBMale.TabIndex = 41;
            this.RBMale.TabStop = true;
            this.RBMale.Text = "Male";
            this.RBMale.UseVisualStyleBackColor = true;
            // 
            // MTBPhoneNumber
            // 
            this.MTBPhoneNumber.Location = new System.Drawing.Point(187, 384);
            this.MTBPhoneNumber.Mask = "(999) 000-0000";
            this.MTBPhoneNumber.Name = "MTBPhoneNumber";
            this.MTBPhoneNumber.Size = new System.Drawing.Size(158, 27);
            this.MTBPhoneNumber.TabIndex = 40;
            this.MTBPhoneNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(187, 301);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(158, 27);
            this.TxtPassword.TabIndex = 39;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(187, 232);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(158, 27);
            this.TxtEmail.TabIndex = 38;
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(187, 165);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(158, 27);
            this.TxtSurname.TabIndex = 37;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(187, 103);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(158, 27);
            this.TxtName.TabIndex = 36;
            // 
            // TxtIdentityNumber
            // 
            this.TxtIdentityNumber.Location = new System.Drawing.Point(187, 46);
            this.TxtIdentityNumber.Name = "TxtIdentityNumber";
            this.TxtIdentityNumber.Size = new System.Drawing.Size(158, 27);
            this.TxtIdentityNumber.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(102, 304);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 19);
            this.label11.TabIndex = 34;
            this.label11.Text = "Password:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(385, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 19);
            this.label10.TabIndex = 33;
            this.label10.Text = "Profession:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(405, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 19);
            this.label9.TabIndex = 32;
            this.label9.Text = "Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 19);
            this.label8.TabIndex = 31;
            this.label8.Text = "Birth Place:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(389, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 19);
            this.label7.TabIndex = 30;
            this.label7.Text = "Birth Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 29;
            this.label6.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "Phone Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Identity Number:";
            // 
            // CompanyOwnerRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.RTBAddress);
            this.Controls.Add(this.RTBBirthPlace);
            this.Controls.Add(this.CMBProfession);
            this.Controls.Add(this.DTPBirthDate);
            this.Controls.Add(this.RBFemale);
            this.Controls.Add(this.RBMale);
            this.Controls.Add(this.MTBPhoneNumber);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtIdentityNumber);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "CompanyOwnerRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company Owner Register Form";
            this.Load += new System.EventHandler(this.CompanyOwnerRegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.RichTextBox RTBAddress;
        private System.Windows.Forms.RichTextBox RTBBirthPlace;
        private System.Windows.Forms.ComboBox CMBProfession;
        private System.Windows.Forms.DateTimePicker DTPBirthDate;
        private System.Windows.Forms.RadioButton RBFemale;
        private System.Windows.Forms.RadioButton RBMale;
        private System.Windows.Forms.MaskedTextBox MTBPhoneNumber;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtIdentityNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}