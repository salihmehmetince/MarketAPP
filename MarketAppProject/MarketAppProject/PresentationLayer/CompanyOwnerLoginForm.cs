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
            string username = TxtUsername.Text;
            string password = TxtPassword.Text;
            CompanyOwnerManager companyOwnerManager = new CompanyOwnerManager();
            TblCompanyOwner companyOwner = companyOwnerManager.BLCompanyOwnerList().FirstOrDefault(co => co.companyOwnerEmail == username && co.companyOwnerPassword == password);
            if(companyOwner==null)
            {
                MessageBox.Show("Company owner couldn't found","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                CompanyOwnerHasCompaniesListForm companyOwnerHasCompaniesListForm=new CompanyOwnerHasCompaniesListForm(companyOwner);
                companyOwnerHasCompaniesListForm.Show();
                this.Hide();
            }
            
        }

        private void LLRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CompanyOwnerRegisterForm companyOwnerRegisterForm = new CompanyOwnerRegisterForm(); 
            companyOwnerRegisterForm.ShowDialog();
        }
    }
}
