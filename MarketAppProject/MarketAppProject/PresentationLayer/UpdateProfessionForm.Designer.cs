namespace MarketAppProject.PresentationLayer
{
    partial class UpdateProfessionForm
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
            this.BtnUpdateProfession = new System.Windows.Forms.Button();
            this.TxtProfession = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnUpdateProfession
            // 
            this.BtnUpdateProfession.BackColor = System.Drawing.Color.Cyan;
            this.BtnUpdateProfession.Location = new System.Drawing.Point(151, 120);
            this.BtnUpdateProfession.Name = "BtnUpdateProfession";
            this.BtnUpdateProfession.Size = new System.Drawing.Size(154, 38);
            this.BtnUpdateProfession.TabIndex = 5;
            this.BtnUpdateProfession.Text = "Update";
            this.BtnUpdateProfession.UseVisualStyleBackColor = false;
            this.BtnUpdateProfession.Click += new System.EventHandler(this.BtnUpdateProfession_Click);
            // 
            // TxtProfession
            // 
            this.TxtProfession.Location = new System.Drawing.Point(151, 76);
            this.TxtProfession.Name = "TxtProfession";
            this.TxtProfession.Size = new System.Drawing.Size(154, 27);
            this.TxtProfession.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Profession Name:";
            // 
            // UpdateProfessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(452, 196);
            this.Controls.Add(this.BtnUpdateProfession);
            this.Controls.Add(this.TxtProfession);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "UpdateProfessionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Profession Form";
            this.Load += new System.EventHandler(this.UpdateProfessionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnUpdateProfession;
        private System.Windows.Forms.TextBox TxtProfession;
        private System.Windows.Forms.Label label1;
    }
}