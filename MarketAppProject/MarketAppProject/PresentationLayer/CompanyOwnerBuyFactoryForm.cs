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
    public partial class CompanyOwnerBuyFactoryForm : Form
    {
        private TblCompanyOwner companyOwner;
        private TblCompany company;
        public CompanyOwnerBuyFactoryForm(TblCompanyOwner companyOwner, TblCompany company)
        {
            InitializeComponent();
            this.companyOwner = companyOwner;
            this.company = company;
        }

        private void CompanyOwnerBuyFactoryForm_Load(object sender, EventArgs e)
        {
            FactoryManager factoryManager = new FactoryManager();
            List<TblFactory> companyHasFactories = factoryManager.BLFactoryList();

            CMBFactory.DataSource = companyHasFactories;
            CMBFactory.DisplayMember = "factoryName";
            CMBFactory.ValueMember = "factoryId";
        }

        private void BtnBuyFactory_Click(object sender, EventArgs e)
        {
            int factoryId=Convert.ToInt32(CMBFactory.SelectedValue);
            CompanyHasFactoryManager companyHasFactoryManager = new CompanyHasFactoryManager();
            TblCompanyHasFactory companyHasFactory = new TblCompanyHasFactory();
            companyHasFactory.companyId = company.companyId;
            companyHasFactory.factoryId = factoryId;
            companyHasFactory.ownershipStartDate = DateTime.Today;
            companyHasFactory.isActive = true;

            int companyHasFactoryId = companyHasFactoryManager.BLCompanyHasFactoryAdd(companyHasFactory);
            if (companyHasFactoryId > 0)
            {
                MessageBox.Show("Successfully bought", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
