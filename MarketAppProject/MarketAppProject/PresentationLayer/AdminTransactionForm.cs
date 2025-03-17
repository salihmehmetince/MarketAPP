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
    public partial class AdminTransactionForm : Form
    {
        public AdminTransactionForm()
        {
            InitializeComponent();
        }

        private void AdminTransactionForm_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.AppIcon;
        }
    }
}
