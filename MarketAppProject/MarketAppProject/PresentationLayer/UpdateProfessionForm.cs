using MarketAppProject.DataAccessLayer;
using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketAppProject.PresentationLayer
{
    public partial class UpdateProfessionForm : Form
    {
        private TblProfession profession;
        public UpdateProfessionForm(TblProfession profession)
        {
            this.profession = profession;
            InitializeComponent();
        }

        private void BtnUpdateProfession_Click(object sender, EventArgs e)
        {
            string professionName=TxtProfession.Text;
            ProfessionManager professionManager=new ProfessionManager();
            profession.professionName = professionName;
            int result = professionManager.BLProfessionUpdate(profession);
            if(result>0)
            {
                MessageBox.Show("Successfully updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            { 
                MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateProfessionForm_Load(object sender, EventArgs e)
        {
            TxtProfession.Text = profession.professionName;
        }
    }
}
