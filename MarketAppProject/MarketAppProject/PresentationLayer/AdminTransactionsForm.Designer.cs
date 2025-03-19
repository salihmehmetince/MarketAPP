namespace MarketAppProject.PresentationLayer
{
    partial class AdminTransactionsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnProfession = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnCountry = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnCompanyType = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnProfession);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profession Transactions";
            // 
            // BtnProfession
            // 
            this.BtnProfession.BackgroundImage = global::MarketAppProject.Properties.Resources.professionIcon;
            this.BtnProfession.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnProfession.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnProfession.Location = new System.Drawing.Point(3, 23);
            this.BtnProfession.Name = "BtnProfession";
            this.BtnProfession.Size = new System.Drawing.Size(184, 127);
            this.BtnProfession.TabIndex = 1;
            this.BtnProfession.UseVisualStyleBackColor = true;
            this.BtnProfession.Click += new System.EventHandler(this.BtnProfession_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnCountry);
            this.groupBox2.Location = new System.Drawing.Point(208, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 153);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Country Transactions";
            // 
            // BtnCountry
            // 
            this.BtnCountry.BackgroundImage = global::MarketAppProject.Properties.Resources.countryIcon;
            this.BtnCountry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCountry.Location = new System.Drawing.Point(3, 23);
            this.BtnCountry.Name = "BtnCountry";
            this.BtnCountry.Size = new System.Drawing.Size(184, 127);
            this.BtnCountry.TabIndex = 1;
            this.BtnCountry.UseVisualStyleBackColor = true;
            this.BtnCountry.Click += new System.EventHandler(this.BtnCountry_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnCompanyType);
            this.groupBox3.Location = new System.Drawing.Point(404, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(190, 153);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Company Type Transactions";
            // 
            // BtnCompanyType
            // 
            this.BtnCompanyType.BackgroundImage = global::MarketAppProject.Properties.Resources.companyTypeIcon;
            this.BtnCompanyType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCompanyType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCompanyType.Location = new System.Drawing.Point(3, 23);
            this.BtnCompanyType.Name = "BtnCompanyType";
            this.BtnCompanyType.Size = new System.Drawing.Size(184, 127);
            this.BtnCompanyType.TabIndex = 1;
            this.BtnCompanyType.UseVisualStyleBackColor = true;
            this.BtnCompanyType.Click += new System.EventHandler(this.BtnCompanyType_Click);
            // 
            // AdminTransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1182, 453);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminTransactionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Transactions Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnProfession;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnCountry;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnCompanyType;
    }
}