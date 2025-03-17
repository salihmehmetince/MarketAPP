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

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.AppIcon;
            BtnAdminLogin.Image = Properties.Resources.adminIcon;
            BtnCompanyOwnerLogin.Image = Properties.Resources.userIcon;
        }

        private void BtnAdminEnter_Click(object sender, EventArgs e)
        {
            AdminLoginForm adminLoginForm = new AdminLoginForm();
            adminLoginForm.Show();
            this.Hide();
        }

        private void BtnUserEnter_Click(object sender, EventArgs e)
        {
            CompanyOwnerLoginForm companyOwnerLoginForm = new CompanyOwnerLoginForm();
            companyOwnerLoginForm.Show();
            this.Hide();
        }
    }
}
