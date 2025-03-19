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
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username=TxtUsername.Text;
            string password=TxtPassword.Text;
            AdminManager adminManager = new AdminManager();
            TblAdmin admin = adminManager.BLAdminList().FirstOrDefault(a=>a.adminUsername==username && a.adminPassword==password);
            if (admin == null) 
            {
                MessageBox.Show("Admin couldn't found","Warning",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                AdminTransactionsForm adminTransactionsForm = new AdminTransactionsForm();
                adminTransactionsForm.Show();
                this.Close();
            }
        }
    }
}
