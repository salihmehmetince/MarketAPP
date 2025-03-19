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
    public partial class CompanyTransactionsForm : Form
    {

        
        public CompanyTransactionsForm()
        {
            InitializeComponent();
        }

        private void BtnAddCompany_Click(object sender, EventArgs e)
        {
            DefineCompanyForm defineCompanyForm = new DefineCompanyForm();
            defineCompanyForm.ShowDialog();
        }
    }
}
