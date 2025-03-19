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
    public partial class AddCompanyTypeForm : Form
    {
        public AddCompanyTypeForm()
        {
            InitializeComponent();
        }

        private void BtnSaveCompanyType_Click(object sender, EventArgs e)
        {
            string companyTypeName = TxtCompanyTypeName.Text;
            TblCompanyType companyType = new TblCompanyType();
            companyType.companyTypeName = companyTypeName;
            CompanyTypeManager companyTypeManager = new CompanyTypeManager();
            int result = companyTypeManager.BLCompanyTypeAdd(companyType);
            if (result > 0)
            {
                MessageBox.Show("Successfully saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
