namespace MarketAppProject.PresentationLayer
{
    partial class CompanyOwnerBuyCompanyForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.TxtOwnerPercent = new System.Windows.Forms.TextBox();
            this.BtnBuyCompany = new System.Windows.Forms.Button();
            this.CMBCompany = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Company Owner Percent:";
            // 
            // TxtOwnerPercent
            // 
            this.TxtOwnerPercent.Location = new System.Drawing.Point(202, 82);
            this.TxtOwnerPercent.Name = "TxtOwnerPercent";
            this.TxtOwnerPercent.Size = new System.Drawing.Size(181, 27);
            this.TxtOwnerPercent.TabIndex = 7;
            // 
            // BtnBuyCompany
            // 
            this.BtnBuyCompany.BackColor = System.Drawing.Color.Turquoise;
            this.BtnBuyCompany.ForeColor = System.Drawing.Color.White;
            this.BtnBuyCompany.Location = new System.Drawing.Point(202, 143);
            this.BtnBuyCompany.Name = "BtnBuyCompany";
            this.BtnBuyCompany.Size = new System.Drawing.Size(181, 33);
            this.BtnBuyCompany.TabIndex = 8;
            this.BtnBuyCompany.Text = "Buy Company";
            this.BtnBuyCompany.UseVisualStyleBackColor = false;
            this.BtnBuyCompany.Click += new System.EventHandler(this.BtnBuyCompany_Click);
            // 
            // CMBCompany
            // 
            this.CMBCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBCompany.FormattingEnabled = true;
            this.CMBCompany.Location = new System.Drawing.Point(202, 37);
            this.CMBCompany.Name = "CMBCompany";
            this.CMBCompany.Size = new System.Drawing.Size(181, 27);
            this.CMBCompany.TabIndex = 9;
            // 
            // CompanyOwnerBuyCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(463, 286);
            this.Controls.Add(this.CMBCompany);
            this.Controls.Add(this.BtnBuyCompany);
            this.Controls.Add(this.TxtOwnerPercent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "CompanyOwnerBuyCompanyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buy A Company";
            this.Load += new System.EventHandler(this.CompanyOwnerBuyCompanyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtOwnerPercent;
        private System.Windows.Forms.Button BtnBuyCompany;
        private System.Windows.Forms.ComboBox CMBCompany;
    }
}