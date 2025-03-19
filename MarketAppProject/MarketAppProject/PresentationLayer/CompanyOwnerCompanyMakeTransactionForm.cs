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
    public partial class CompanyOwnerCompanyMakeTransactionForm : Form
    {
        private TblCompanyOwner companyOwner;
        private TblCompany company;
        private TblCompanyOwerHasCompany companyOwerHasCompany;
        public CompanyOwnerCompanyMakeTransactionForm(TblCompanyOwner companyOwner,TblCompany company, TblCompanyOwerHasCompany companyOwerHasCompany)
        {
            this.companyOwner = companyOwner;
            this.company = company;
            this.companyOwerHasCompany = companyOwerHasCompany;
            InitializeComponent();
        }

        private void CompanyOwnerCompanyMakeTransactionForm_Load(object sender, EventArgs e)
        {
            this.Text = company.companyName;

        }

        private void BtnUpdateCompany_Click(object sender, EventArgs e)
        {
            UpdateCompanyOwnerHasCompanyForm updateCompanyOwnerHasCompanyForm = new UpdateCompanyOwnerHasCompanyForm(company,companyOwerHasCompany);
            updateCompanyOwnerHasCompanyForm.ShowDialog();
        }

        private void BtnDeleteCompany_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("Do you want to delete this company?","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (result == DialogResult.OK) 
            {
                CompanyOwnerHasCompanyManager companyOwnerHasCompanyManager = new CompanyOwnerHasCompanyManager();
                companyOwerHasCompany.isActive = false;
                companyOwerHasCompany.endDate = DateTime.Today;
                int companyOwerHasCompanyId = companyOwnerHasCompanyManager.BLCompanyOwerHasCompanyUpdate(companyOwerHasCompany);
                if(companyOwerHasCompanyId>0)
                {
                    MessageBox.Show("Successfully deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("The process canceled","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
