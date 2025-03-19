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
    public partial class CompanyOwnerBuyCompanyForm : Form
    {
        private TblCompanyOwner companyOwner;
        public CompanyOwnerBuyCompanyForm(TblCompanyOwner companyOwner)
        {
            this.companyOwner = companyOwner;
            InitializeComponent();
        }

        private void CompanyOwnerBuyCompanyForm_Load(object sender, EventArgs e)
        {

            CompanyManager companyManager = new CompanyManager();
            List<TblCompany> companies = companyManager.BLCompanyList();

            CMBCompany.DataSource = companies;
            CMBCompany.DisplayMember = "companyName";
            CMBCompany.ValueMember = "companyId";
        }

        private void BtnBuyCompany_Click(object sender, EventArgs e)
        {
            int company = Convert.ToInt32(CMBCompany.SelectedValue);
            double companyOwnerPercent = Convert.ToDouble(TxtOwnerPercent.Text);
            
            CompanyOwnerHasCompanyManager companyOwnerHasCompanyManager = new CompanyOwnerHasCompanyManager();
            TblCompanyOwerHasCompany tblCompanyOwerHasCompany=new TblCompanyOwerHasCompany();
            tblCompanyOwerHasCompany.company = company;
            tblCompanyOwerHasCompany.companyOwner = companyOwner.companyOwnerId;
            tblCompanyOwerHasCompany.companyOwnerPercent = companyOwnerPercent;
            tblCompanyOwerHasCompany.startDate = DateTime.Today;
            tblCompanyOwerHasCompany.isActive = true;
            int companyOwnerHasCompanyId = companyOwnerHasCompanyManager.BLCompanyOwerHasCompanyAdd(tblCompanyOwerHasCompany);
            if( companyOwnerHasCompanyId > 0 )
            {
                MessageBox.Show("Successfully bought", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
