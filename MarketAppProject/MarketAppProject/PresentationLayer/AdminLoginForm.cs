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

        private void AdminLoginForm_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.AppIcon;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string userName = TxtUsername.Text;
            string password = TxtPassword.Text;
            AdminManager adminManager = new AdminManager();
            TblAdmin admin = adminManager.BLAdminList().Where(a => a.adminUsername == userName && a.adminPassword == password).FirstOrDefault();
            if (admin != null) 
            {
                AdminTransactionForm adminTransactionForm = new AdminTransactionForm();
                adminTransactionForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Admin couldn't find","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
