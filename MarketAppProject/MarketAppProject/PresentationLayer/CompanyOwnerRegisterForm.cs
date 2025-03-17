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
    public partial class CompanyOwnerRegisterForm : Form
    {
        public CompanyOwnerRegisterForm()
        {
            InitializeComponent();
        }

        private void LblProfession_Click(object sender, EventArgs e)
        {

        }

        private void CompanyOwnerRegisterForm_Load(object sender, EventArgs e)
        {
            ProfessionManager professionManager = new ProfessionManager();
            List<TblProfession> professions = professionManager.BLProfessionList();
            
        }
    }
}
