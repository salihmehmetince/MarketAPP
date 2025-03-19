namespace MarketAppProject.PresentationLayer
{
    partial class AddCountryForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCountryName = new System.Windows.Forms.TextBox();
            this.TxtCountryProductionCode = new System.Windows.Forms.TextBox();
            this.BtnSaveCountry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Country Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Country Production Code:";
            // 
            // TxtCountryName
            // 
            this.TxtCountryName.Location = new System.Drawing.Point(207, 56);
            this.TxtCountryName.Name = "TxtCountryName";
            this.TxtCountryName.Size = new System.Drawing.Size(182, 27);
            this.TxtCountryName.TabIndex = 2;
            // 
            // TxtCountryProductionCode
            // 
            this.TxtCountryProductionCode.Location = new System.Drawing.Point(207, 96);
            this.TxtCountryProductionCode.MaxLength = 3;
            this.TxtCountryProductionCode.Name = "TxtCountryProductionCode";
            this.TxtCountryProductionCode.Size = new System.Drawing.Size(182, 27);
            this.TxtCountryProductionCode.TabIndex = 3;
            // 
            // BtnSaveCountry
            // 
            this.BtnSaveCountry.BackColor = System.Drawing.Color.Tan;
            this.BtnSaveCountry.Location = new System.Drawing.Point(207, 148);
            this.BtnSaveCountry.Name = "BtnSaveCountry";
            this.BtnSaveCountry.Size = new System.Drawing.Size(182, 31);
            this.BtnSaveCountry.TabIndex = 4;
            this.BtnSaveCountry.Text = "Save";
            this.BtnSaveCountry.UseVisualStyleBackColor = false;
            this.BtnSaveCountry.Click += new System.EventHandler(this.BtnSaveCountry_Click);
            // 
            // AddCountryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(450, 244);
            this.Controls.Add(this.BtnSaveCountry);
            this.Controls.Add(this.TxtCountryProductionCode);
            this.Controls.Add(this.TxtCountryName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "AddCountryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Country Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCountryName;
        private System.Windows.Forms.TextBox TxtCountryProductionCode;
        private System.Windows.Forms.Button BtnSaveCountry;
    }
}