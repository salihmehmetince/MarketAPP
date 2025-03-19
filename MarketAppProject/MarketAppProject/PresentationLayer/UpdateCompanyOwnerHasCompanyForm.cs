using MarketAppProject.BusinessLogicLayer;
using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketAppProject.PresentationLayer
{
    public partial class UpdateCompanyOwnerHasCompanyForm : Form
    {
        private TblCompany company;
        private TblCompanyOwerHasCompany companyOwerHasCompany;
        public UpdateCompanyOwnerHasCompanyForm(TblCompany company,TblCompanyOwerHasCompany companyOwerHasCompany)
        {
            InitializeComponent();
            this.companyOwerHasCompany = companyOwerHasCompany;
            this.company = company;
        }

        private void UpdateCompanyOwnerHasCompanyForm_Load(object sender, EventArgs e)
        {
            CompanyTypeManager companyTypeManager = new CompanyTypeManager();
            List<TblCompanyType> tblCompanyTypes = companyTypeManager.BLCompanyTypeList();

            CountryManager countryManager = new CountryManager();
            List<TblCountry> countries = countryManager.BLCountryList();

            CompanyManager companyManager = new CompanyManager();
            List<TblCompany> companies = companyManager.BLCompanyList();

            CMBCompanyType.DataSource = tblCompanyTypes;
            CMBCompanyType.DisplayMember = "companyTypeName";
            CMBCompanyType.ValueMember = "companyTypeId";

            CMBCountry.DataSource = countries;
            CMBCountry.DisplayMember = "countryName";
            CMBCountry.ValueMember = "countryId";
            
            CMBCompany.DataSource = companies;
            CMBCompany.DisplayMember = "companyName";
            CMBCompany.ValueMember = "companyId";

            CMBCountry.SelectedValue = company.companyCountry;
            CMBCompanyType.SelectedValue = company.companyType;
            TxtOwnerPercent.Text=companyOwerHasCompany.companyOwnerPercent.ToString();
        }

        private void BtnUpdateCompany_Click(object sender, EventArgs e)
        {
            double companyOwnerPercent = Convert.ToDouble(TxtOwnerPercent.Text);

            CompanyOwnerHasCompanyManager companyOwnerHasCompanyManager = new CompanyOwnerHasCompanyManager();
            companyOwerHasCompany.companyOwnerPercent = companyOwnerPercent;
            int companyOwnerHasCompanyId = companyOwnerHasCompanyManager.BLCompanyOwerHasCompanyUpdate(companyOwerHasCompany);
            if (companyOwnerHasCompanyId > 0)
            {
                MessageBox.Show("Successfully Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
