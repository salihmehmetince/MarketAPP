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
    public partial class UpdateCompanyTypeForm : Form
    {
        private TblCompanyType companyType;
        public UpdateCompanyTypeForm(TblCompanyType companyType)
        {
            this.companyType = companyType;
            InitializeComponent();
        }

        private void BtnUpdateCompanyType_Click(object sender, EventArgs e)
        {
            string companyTypeName = TxtCompanyTypeName.Text;
            CompanyTypeManager companyTypeManager = new CompanyTypeManager();
            companyType.companyTypeName = companyTypeName;
            int result = companyTypeManager.BLCompanyTypeUpdate(companyType);
            if (result > 0)
            {
                MessageBox.Show("Successfully updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateCompanyTypeForm_Load(object sender, EventArgs e)
        {
            TxtCompanyTypeName.Text=companyType.companyTypeName;
        }
    }
}
