namespace MarketAppProject.PresentationLayer
{
    partial class UpdateCountryForm
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
            this.BtnUpdateCountry = new System.Windows.Forms.Button();
            this.TxtCountryProductionCode = new System.Windows.Forms.TextBox();
            this.TxtCountryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnUpdateCountry
            // 
            this.BtnUpdateCountry.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnUpdateCountry.Location = new System.Drawing.Point(208, 165);
            this.BtnUpdateCountry.Name = "BtnUpdateCountry";
            this.BtnUpdateCountry.Size = new System.Drawing.Size(182, 31);
            this.BtnUpdateCountry.TabIndex = 9;
            this.BtnUpdateCountry.Text = "Update";
            this.BtnUpdateCountry.UseVisualStyleBackColor = false;
            this.BtnUpdateCountry.Click += new System.EventHandler(this.BtnUpdateCountry_Click);
            // 
            // TxtCountryProductionCode
            // 
            this.TxtCountryProductionCode.Location = new System.Drawing.Point(208, 113);
            this.TxtCountryProductionCode.MaxLength = 3;
            this.TxtCountryProductionCode.Name = "TxtCountryProductionCode";
            this.TxtCountryProductionCode.Size = new System.Drawing.Size(182, 27);
            this.TxtCountryProductionCode.TabIndex = 8;
            // 
            // TxtCountryName
            // 
            this.TxtCountryName.Location = new System.Drawing.Point(208, 73);
            this.TxtCountryName.Name = "TxtCountryName";
            this.TxtCountryName.Size = new System.Drawing.Size(182, 27);
            this.TxtCountryName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Country Production Code:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Country Name:";
            // 
            // UpdateCountryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(462, 230);
            this.Controls.Add(this.BtnUpdateCountry);
            this.Controls.Add(this.TxtCountryProductionCode);
            this.Controls.Add(this.TxtCountryName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "UpdateCountryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Country Form";
            this.Load += new System.EventHandler(this.UpdateCountryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnUpdateCountry;
        private System.Windows.Forms.TextBox TxtCountryProductionCode;
        private System.Windows.Forms.TextBox TxtCountryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}