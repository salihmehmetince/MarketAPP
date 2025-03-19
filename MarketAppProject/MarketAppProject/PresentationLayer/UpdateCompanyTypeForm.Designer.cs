namespace MarketAppProject.PresentationLayer
{
    partial class UpdateCompanyTypeForm
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
            this.BtnUpdateCompanyType = new System.Windows.Forms.Button();
            this.TxtCompanyTypeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnUpdateCompanyType
            // 
            this.BtnUpdateCompanyType.BackColor = System.Drawing.Color.PeachPuff;
            this.BtnUpdateCompanyType.Location = new System.Drawing.Point(176, 90);
            this.BtnUpdateCompanyType.Name = "BtnUpdateCompanyType";
            this.BtnUpdateCompanyType.Size = new System.Drawing.Size(182, 31);
            this.BtnUpdateCompanyType.TabIndex = 12;
            this.BtnUpdateCompanyType.Text = "Update";
            this.BtnUpdateCompanyType.UseVisualStyleBackColor = false;
            this.BtnUpdateCompanyType.Click += new System.EventHandler(this.BtnUpdateCompanyType_Click);
            // 
            // TxtCompanyTypeName
            // 
            this.TxtCompanyTypeName.Location = new System.Drawing.Point(176, 29);
            this.TxtCompanyTypeName.Name = "TxtCompanyTypeName";
            this.TxtCompanyTypeName.Size = new System.Drawing.Size(182, 27);
            this.TxtCompanyTypeName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Company Type Name:";
            // 
            // UpdateCompanyTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(420, 151);
            this.Controls.Add(this.BtnUpdateCompanyType);
            this.Controls.Add(this.TxtCompanyTypeName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "UpdateCompanyTypeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Company Type Form";
            this.Load += new System.EventHandler(this.UpdateCompanyTypeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnUpdateCompanyType;
        private System.Windows.Forms.TextBox TxtCompanyTypeName;
        private System.Windows.Forms.Label label1;
    }
}