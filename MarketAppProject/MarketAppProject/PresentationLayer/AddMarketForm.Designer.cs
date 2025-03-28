﻿namespace MarketAppProject.PresentationLayer
{
    partial class AddMarketForm
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
            this.TxtmarketName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MTBPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.TxtmarketEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnSaveMarket = new System.Windows.Forms.Button();
            this.RTBAddress = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Market Name:";
            // 
            // TxtmarketName
            // 
            this.TxtmarketName.Location = new System.Drawing.Point(187, 64);
            this.TxtmarketName.Name = "TxtmarketName";
            this.TxtmarketName.Size = new System.Drawing.Size(143, 27);
            this.TxtmarketName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Market Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Market Phone Number:";
            // 
            // MTBPhoneNumber
            // 
            this.MTBPhoneNumber.Location = new System.Drawing.Point(187, 217);
            this.MTBPhoneNumber.Mask = "(999) 000-0000";
            this.MTBPhoneNumber.Name = "MTBPhoneNumber";
            this.MTBPhoneNumber.Size = new System.Drawing.Size(143, 27);
            this.MTBPhoneNumber.TabIndex = 5;
            this.MTBPhoneNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // TxtmarketEmail
            // 
            this.TxtmarketEmail.Location = new System.Drawing.Point(187, 267);
            this.TxtmarketEmail.Name = "TxtmarketEmail";
            this.TxtmarketEmail.Size = new System.Drawing.Size(143, 27);
            this.TxtmarketEmail.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Market Email:";
            // 
            // BtnSaveMarket
            // 
            this.BtnSaveMarket.BackColor = System.Drawing.Color.Aquamarine;
            this.BtnSaveMarket.Location = new System.Drawing.Point(187, 300);
            this.BtnSaveMarket.Name = "BtnSaveMarket";
            this.BtnSaveMarket.Size = new System.Drawing.Size(143, 42);
            this.BtnSaveMarket.TabIndex = 8;
            this.BtnSaveMarket.Text = "Save";
            this.BtnSaveMarket.UseVisualStyleBackColor = false;
            this.BtnSaveMarket.Click += new System.EventHandler(this.BtnSaveMarket_Click);
            // 
            // RTBAddress
            // 
            this.RTBAddress.Location = new System.Drawing.Point(187, 111);
            this.RTBAddress.Name = "RTBAddress";
            this.RTBAddress.Size = new System.Drawing.Size(218, 71);
            this.RTBAddress.TabIndex = 9;
            this.RTBAddress.Text = "";
            // 
            // AddMarketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(417, 365);
            this.Controls.Add(this.RTBAddress);
            this.Controls.Add(this.BtnSaveMarket);
            this.Controls.Add(this.TxtmarketEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MTBPhoneNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtmarketName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "AddMarketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Market Form";
            this.Load += new System.EventHandler(this.AddMarketForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtmarketName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MTBPhoneNumber;
        private System.Windows.Forms.TextBox TxtmarketEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnSaveMarket;
        private System.Windows.Forms.RichTextBox RTBAddress;
    }
}