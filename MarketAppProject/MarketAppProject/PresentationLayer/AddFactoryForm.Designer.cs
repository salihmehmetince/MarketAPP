namespace MarketAppProject.PresentationLayer
{
    partial class AddFactoryForm
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
            this.TxtFactoryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RTBAddress = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MTBPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CMBCountry = new System.Windows.Forms.ComboBox();
            this.TxtFactoryproductionCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnSaveFactory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Factory Name:";
            // 
            // TxtFactoryName
            // 
            this.TxtFactoryName.Location = new System.Drawing.Point(218, 46);
            this.TxtFactoryName.Name = "TxtFactoryName";
            this.TxtFactoryName.Size = new System.Drawing.Size(170, 27);
            this.TxtFactoryName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address:";
            // 
            // RTBAddress
            // 
            this.RTBAddress.Location = new System.Drawing.Point(218, 114);
            this.RTBAddress.Name = "RTBAddress";
            this.RTBAddress.Size = new System.Drawing.Size(400, 76);
            this.RTBAddress.TabIndex = 3;
            this.RTBAddress.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone Number:";
            // 
            // MTBPhoneNumber
            // 
            this.MTBPhoneNumber.Location = new System.Drawing.Point(218, 224);
            this.MTBPhoneNumber.Mask = "(999) 000-0000";
            this.MTBPhoneNumber.Name = "MTBPhoneNumber";
            this.MTBPhoneNumber.Size = new System.Drawing.Size(170, 27);
            this.MTBPhoneNumber.TabIndex = 5;
            this.MTBPhoneNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(218, 275);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(170, 27);
            this.TxtEmail.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Country:";
            // 
            // CMBCountry
            // 
            this.CMBCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBCountry.FormattingEnabled = true;
            this.CMBCountry.Location = new System.Drawing.Point(218, 332);
            this.CMBCountry.Name = "CMBCountry";
            this.CMBCountry.Size = new System.Drawing.Size(170, 27);
            this.CMBCountry.TabIndex = 9;
            // 
            // TxtFactoryproductionCode
            // 
            this.TxtFactoryproductionCode.Location = new System.Drawing.Point(218, 386);
            this.TxtFactoryproductionCode.Name = "TxtFactoryproductionCode";
            this.TxtFactoryproductionCode.Size = new System.Drawing.Size(170, 27);
            this.TxtFactoryproductionCode.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Factory Production Code:";
            // 
            // BtnSaveFactory
            // 
            this.BtnSaveFactory.BackColor = System.Drawing.Color.OldLace;
            this.BtnSaveFactory.Location = new System.Drawing.Point(218, 434);
            this.BtnSaveFactory.Name = "BtnSaveFactory";
            this.BtnSaveFactory.Size = new System.Drawing.Size(170, 29);
            this.BtnSaveFactory.TabIndex = 12;
            this.BtnSaveFactory.Text = "Save";
            this.BtnSaveFactory.UseVisualStyleBackColor = false;
            this.BtnSaveFactory.Click += new System.EventHandler(this.BtnSaveFactory_Click);
            // 
            // AddFactoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.BtnSaveFactory);
            this.Controls.Add(this.TxtFactoryproductionCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CMBCountry);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MTBPhoneNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RTBAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtFactoryName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "AddFactoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Factory Form";
            this.Load += new System.EventHandler(this.AddFactoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFactoryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox RTBAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MTBPhoneNumber;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CMBCountry;
        private System.Windows.Forms.TextBox TxtFactoryproductionCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnSaveFactory;
    }
}