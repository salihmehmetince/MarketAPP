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
    public partial class DefineCompanyForm : Form
    {
        public DefineCompanyForm()
        {
            InitializeComponent();
        }

        private void BtnDefineCompany_Click(object sender, EventArgs e)
        {
            string companyName = TxtCompanyName.Text;
            int country = Convert.ToInt32(CMBCountry.SelectedValue);
            int companyType = Convert.ToInt32(CMBCompanyType.SelectedValue);

            TblCompany company = new TblCompany();
            company.companyName = companyName;
            company.companyType = companyType;
            company.companyCountry = country;

            CompanyManager companyManager = new CompanyManager();
            TblCompany tblCompany = companyManager.BLCompanyList().FirstOrDefault(c => c.companyName == company.companyName);

            int companyId = 0;
            if (tblCompany == null)
            {
                companyId = companyManager.BLCompanyAdd(company);
                if (companyId > 0)
                {
                    MessageBox.Show("Successfully saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("the Company couldn't saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void DefineCompanyForm_Load(object sender, EventArgs e)
        {
            CompanyTypeManager companyTypeManager = new CompanyTypeManager();
            List<TblCompanyType> tblCompanyTypes = companyTypeManager.BLCompanyTypeList();

            CountryManager countryManager = new CountryManager();
            List<TblCountry> countries = countryManager.BLCountryList();

            CMBCompanyType.DataSource = tblCompanyTypes;
            CMBCompanyType.DisplayMember = "companyTypeName";
            CMBCompanyType.ValueMember = "companyTypeId";

            CMBCountry.DataSource = countries;
            CMBCountry.DisplayMember = "countryName";
            CMBCountry.ValueMember = "countryId";
        }
    }
}
