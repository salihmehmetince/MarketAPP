namespace MarketAppProject.PresentationLayer
{
    partial class AddCompanyTypeForm
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
            this.BtnSaveCompanyType = new System.Windows.Forms.Button();
            this.TxtCompanyTypeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSaveCompanyType
            // 
            this.BtnSaveCompanyType.BackColor = System.Drawing.Color.PeachPuff;
            this.BtnSaveCompanyType.Location = new System.Drawing.Point(206, 122);
            this.BtnSaveCompanyType.Name = "BtnSaveCompanyType";
            this.BtnSaveCompanyType.Size = new System.Drawing.Size(182, 31);
            this.BtnSaveCompanyType.TabIndex = 9;
            this.BtnSaveCompanyType.Text = "Save";
            this.BtnSaveCompanyType.UseVisualStyleBackColor = false;
            this.BtnSaveCompanyType.Click += new System.EventHandler(this.BtnSaveCompanyType_Click);
            // 
            // TxtCompanyTypeName
            // 
            this.TxtCompanyTypeName.Location = new System.Drawing.Point(206, 61);
            this.TxtCompanyTypeName.Name = "TxtCompanyTypeName";
            this.TxtCompanyTypeName.Size = new System.Drawing.Size(182, 27);
            this.TxtCompanyTypeName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Company Type Name:";
            // 
            // AddCompanyTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(412, 221);
            this.Controls.Add(this.BtnSaveCompanyType);
            this.Controls.Add(this.TxtCompanyTypeName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "AddCompanyTypeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Company Type Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSaveCompanyType;
        private System.Windows.Forms.TextBox TxtCompanyTypeName;
        private System.Windows.Forms.Label label1;
    }
}