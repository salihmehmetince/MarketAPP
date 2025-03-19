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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnAdminLogin_Click(object sender, EventArgs e)
        {
            AdminLoginForm form = new AdminLoginForm();
            form.Show();
            this.Hide();
        }

        private void BtnCompanyOwner_Click(object sender, EventArgs e)
        {
            CompanyOwnerLoginForm form = new CompanyOwnerLoginForm();
            form.Show();
            this.Hide();
        }

        private void BtnUserLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
