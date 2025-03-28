namespace MarketAppProject.PresentationLayer
{
    partial class CompanyOwnerBuyFactoryForm
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
            this.CMBFactory = new System.Windows.Forms.ComboBox();
            this.BtnBuyFactory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Factory Name:";
            // 
            // CMBFactory
            // 
            this.CMBFactory.FormattingEnabled = true;
            this.CMBFactory.Location = new System.Drawing.Point(128, 47);
            this.CMBFactory.Name = "CMBFactory";
            this.CMBFactory.Size = new System.Drawing.Size(190, 27);
            this.CMBFactory.TabIndex = 1;
            // 
            // BtnBuyFactory
            // 
            this.BtnBuyFactory.BackColor = System.Drawing.Color.Silver;
            this.BtnBuyFactory.Location = new System.Drawing.Point(128, 91);
            this.BtnBuyFactory.Name = "BtnBuyFactory";
            this.BtnBuyFactory.Size = new System.Drawing.Size(190, 32);
            this.BtnBuyFactory.TabIndex = 2;
            this.BtnBuyFactory.Text = "Buy";
            this.BtnBuyFactory.UseVisualStyleBackColor = false;
            this.BtnBuyFactory.Click += new System.EventHandler(this.BtnBuyFactory_Click);
            // 
            // CompanyOwnerBuyFactoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(424, 153);
            this.Controls.Add(this.BtnBuyFactory);
            this.Controls.Add(this.CMBFactory);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "CompanyOwnerBuyFactoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company Owner Buy Factory Form";
            this.Load += new System.EventHandler(this.CompanyOwnerBuyFactoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CMBFactory;
        private System.Windows.Forms.Button BtnBuyFactory;
    }
}