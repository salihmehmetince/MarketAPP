using MarketAppProject.BusinessLogicLayer;
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
    public partial class CompanyOwnerLoginForm : Form
    {
        public CompanyOwnerLoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string userName = TxtUsername.Text;
            string password = TxtPassword.Text;
            CompanyOwnerManager companyOwnerManager = new CompanyOwnerManager();
            TblCompanyOwner companyOwner = companyOwnerManager.BLCompanyOwnerList().Where(a => a.companyOwnerEmail == userName && a.companyOwnerPassword == password).FirstOrDefault();
            if (companyOwner != null)
            {
                CompanyOwnerHasCompaniesForm companyOwnerHasCompaniesForm = new CompanyOwnerHasCompaniesForm(companyOwner);
                companyOwnerHasCompaniesForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Company owner couldn't find", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
