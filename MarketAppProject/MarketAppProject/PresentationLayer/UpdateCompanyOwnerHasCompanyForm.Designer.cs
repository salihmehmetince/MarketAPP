namespace MarketAppProject.PresentationLayer
{
    partial class UpdateCompanyOwnerHasCompanyForm
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
            this.BtnUpdateCompany = new System.Windows.Forms.Button();
            this.TxtOwnerPercent = new System.Windows.Forms.TextBox();
            this.CMBCountry = new System.Windows.Forms.ComboBox();
            this.CMBCompanyType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CMBCompany = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnUpdateCompany
            // 
            this.BtnUpdateCompany.BackColor = System.Drawing.Color.Turquoise;
            this.BtnUpdateCompany.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateCompany.Location = new System.Drawing.Point(218, 249);
            this.BtnUpdateCompany.Name = "BtnUpdateCompany";
            this.BtnUpdateCompany.Size = new System.Drawing.Size(181, 33);
            this.BtnUpdateCompany.TabIndex = 17;
            this.BtnUpdateCompany.Text = "Update Company";
            this.BtnUpdateCompany.UseVisualStyleBackColor = false;
            this.BtnUpdateCompany.Click += new System.EventHandler(this.BtnUpdateCompany_Click);
            // 
            // TxtOwnerPercent
            // 
            this.TxtOwnerPercent.Location = new System.Drawing.Point(218, 188);
            this.TxtOwnerPercent.Name = "TxtOwnerPercent";
            this.TxtOwnerPercent.Size = new System.Drawing.Size(181, 27);
            this.TxtOwnerPercent.TabIndex = 16;
            // 
            // CMBCountry
            // 
            this.CMBCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBCountry.Enabled = false;
            this.CMBCountry.FormattingEnabled = true;
            this.CMBCountry.Location = new System.Drawing.Point(218, 138);
            this.CMBCountry.Name = "CMBCountry";
            this.CMBCountry.Size = new System.Drawing.Size(181, 27);
            this.CMBCountry.TabIndex = 15;
            // 
            // CMBCompanyType
            // 
            this.CMBCompanyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBCompanyType.Enabled = false;
            this.CMBCompanyType.FormattingEnabled = true;
            this.CMBCompanyType.Location = new System.Drawing.Point(218, 98);
            this.CMBCompanyType.Name = "CMBCompanyType";
            this.CMBCompanyType.Size = new System.Drawing.Size(181, 27);
            this.CMBCompanyType.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Company Owner Percent:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Company Country:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Company Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Company Name:";
            // 
            // CMBCompany
            // 
            this.CMBCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBCompany.Enabled = false;
            this.CMBCompany.FormattingEnabled = true;
            this.CMBCompany.Location = new System.Drawing.Point(218, 61);
            this.CMBCompany.Name = "CMBCompany";
            this.CMBCompany.Size = new System.Drawing.Size(181, 27);
            this.CMBCompany.TabIndex = 18;
            // 
            // UpdateCompanyOwnerHasCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(427, 325);
            this.Controls.Add(this.CMBCompany);
            this.Controls.Add(this.BtnUpdateCompany);
            this.Controls.Add(this.TxtOwnerPercent);
            this.Controls.Add(this.CMBCountry);
            this.Controls.Add(this.CMBCompanyType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "UpdateCompanyOwnerHasCompanyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Company Form";
            this.Load += new System.EventHandler(this.UpdateCompanyOwnerHasCompanyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnUpdateCompany;
        private System.Windows.Forms.TextBox TxtOwnerPercent;
        private System.Windows.Forms.ComboBox CMBCountry;
        private System.Windows.Forms.ComboBox CMBCompanyType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CMBCompany;
    }
}