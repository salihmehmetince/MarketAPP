namespace MarketAppProject.PresentationLayer
{
    partial class CompanyOwnerHasCompaniesListForm
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
            this.BtnBuyCompany = new System.Windows.Forms.Button();
            this.BtnListCompanies = new System.Windows.Forms.Button();
            this.BtnDefineCompany = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnBuyCompany
            // 
            this.BtnBuyCompany.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnBuyCompany.ForeColor = System.Drawing.Color.Yellow;
            this.BtnBuyCompany.Location = new System.Drawing.Point(293, 12);
            this.BtnBuyCompany.Name = "BtnBuyCompany";
            this.BtnBuyCompany.Size = new System.Drawing.Size(169, 47);
            this.BtnBuyCompany.TabIndex = 0;
            this.BtnBuyCompany.Text = "(+) Buy Company";
            this.BtnBuyCompany.UseVisualStyleBackColor = false;
            this.BtnBuyCompany.Click += new System.EventHandler(this.BtnBuyCompany_Click);
            // 
            // BtnListCompanies
            // 
            this.BtnListCompanies.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnListCompanies.ForeColor = System.Drawing.Color.Yellow;
            this.BtnListCompanies.Location = new System.Drawing.Point(468, 12);
            this.BtnListCompanies.Name = "BtnListCompanies";
            this.BtnListCompanies.Size = new System.Drawing.Size(169, 47);
            this.BtnListCompanies.TabIndex = 1;
            this.BtnListCompanies.Text = "List Companies";
            this.BtnListCompanies.UseVisualStyleBackColor = false;
            this.BtnListCompanies.Click += new System.EventHandler(this.BtnListCompanies_Click);
            // 
            // BtnDefineCompany
            // 
            this.BtnDefineCompany.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnDefineCompany.ForeColor = System.Drawing.Color.Yellow;
            this.BtnDefineCompany.Location = new System.Drawing.Point(643, 12);
            this.BtnDefineCompany.Name = "BtnDefineCompany";
            this.BtnDefineCompany.Size = new System.Drawing.Size(169, 47);
            this.BtnDefineCompany.TabIndex = 2;
            this.BtnDefineCompany.Text = "Define Company";
            this.BtnDefineCompany.UseVisualStyleBackColor = false;
            this.BtnDefineCompany.Click += new System.EventHandler(this.BtnDefineCompany_Click);
            // 
            // CompanyOwnerHasCompaniesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1180, 534);
            this.Controls.Add(this.BtnDefineCompany);
            this.Controls.Add(this.BtnListCompanies);
            this.Controls.Add(this.BtnBuyCompany);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "CompanyOwnerHasCompaniesListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company Owner Select Company Form";
            this.Load += new System.EventHandler(this.CompanyOwnerHasCompaniesListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnBuyCompany;
        private System.Windows.Forms.Button BtnListCompanies;
        private System.Windows.Forms.Button BtnDefineCompany;
    }
}