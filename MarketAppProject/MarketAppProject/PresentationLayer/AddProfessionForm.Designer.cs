namespace MarketAppProject.PresentationLayer
{
    partial class AddProfessionForm
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
            this.TxtProfession = new System.Windows.Forms.TextBox();
            this.BtnAddProfession = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profession Name:";
            // 
            // TxtProfession
            // 
            this.TxtProfession.Location = new System.Drawing.Point(151, 55);
            this.TxtProfession.Name = "TxtProfession";
            this.TxtProfession.Size = new System.Drawing.Size(154, 27);
            this.TxtProfession.TabIndex = 1;
            // 
            // BtnAddProfession
            // 
            this.BtnAddProfession.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnAddProfession.Location = new System.Drawing.Point(151, 99);
            this.BtnAddProfession.Name = "BtnAddProfession";
            this.BtnAddProfession.Size = new System.Drawing.Size(154, 38);
            this.BtnAddProfession.TabIndex = 2;
            this.BtnAddProfession.Text = "Save";
            this.BtnAddProfession.UseVisualStyleBackColor = false;
            this.BtnAddProfession.Click += new System.EventHandler(this.BtnAddProfession_Click);
            // 
            // AddProfessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(400, 171);
            this.Controls.Add(this.BtnAddProfession);
            this.Controls.Add(this.TxtProfession);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "AddProfessionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Profession Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtProfession;
        private System.Windows.Forms.Button BtnAddProfession;
    }
}