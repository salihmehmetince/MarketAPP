namespace MarketAppProject.PresentationLayer
{
    partial class DefineCompanyForm
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
            this.CMBCountry = new System.Windows.Forms.ComboBox();
            this.CMBCompanyType = new System.Windows.Forms.ComboBox();
            this.TxtCompanyName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnDefineCompany = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CMBCountry
            // 
            this.CMBCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBCountry.FormattingEnabled = true;
            this.CMBCountry.Location = new System.Drawing.Point(158, 125);
            this.CMBCountry.Name = "CMBCountry";
            this.CMBCountry.Size = new System.Drawing.Size(181, 27);
            this.CMBCountry.TabIndex = 12;
            // 
            // CMBCompanyType
            // 
            this.CMBCompanyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBCompanyType.FormattingEnabled = true;
            this.CMBCompanyType.Location = new System.Drawing.Point(158, 85);
            this.CMBCompanyType.Name = "CMBCompanyType";
            this.CMBCompanyType.Size = new System.Drawing.Size(181, 27);
            this.CMBCompanyType.TabIndex = 11;
            // 
            // TxtCompanyName
            // 
            this.TxtCompanyName.Location = new System.Drawing.Point(158, 45);
            this.TxtCompanyName.Name = "TxtCompanyName";
            this.TxtCompanyName.Size = new System.Drawing.Size(181, 27);
            this.TxtCompanyName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Company Country:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Company Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Company Name:";
            // 
            // BtnDefineCompany
            // 
            this.BtnDefineCompany.BackColor = System.Drawing.Color.Khaki;
            this.BtnDefineCompany.Location = new System.Drawing.Point(158, 165);
            this.BtnDefineCompany.Name = "BtnDefineCompany";
            this.BtnDefineCompany.Size = new System.Drawing.Size(181, 41);
            this.BtnDefineCompany.TabIndex = 13;
            this.BtnDefineCompany.Text = "Create";
            this.BtnDefineCompany.UseVisualStyleBackColor = false;
            this.BtnDefineCompany.Click += new System.EventHandler(this.BtnDefineCompany_Click);
            // 
            // DefineCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(467, 238);
            this.Controls.Add(this.BtnDefineCompany);
            this.Controls.Add(this.CMBCountry);
            this.Controls.Add(this.CMBCompanyType);
            this.Controls.Add(this.TxtCompanyName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "DefineCompanyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Define Company Form";
            this.Load += new System.EventHandler(this.DefineCompanyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CMBCountry;
        private System.Windows.Forms.ComboBox CMBCompanyType;
        private System.Windows.Forms.TextBox TxtCompanyName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnDefineCompany;
    }
}