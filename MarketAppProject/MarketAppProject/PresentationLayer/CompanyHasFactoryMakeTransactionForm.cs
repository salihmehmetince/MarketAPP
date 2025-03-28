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
    public partial class CompanyHasFactoryMakeTransactionForm : Form
    {
        private TblCompanyHasFactory companyHasFactory;
        private TblFactory factory;
        public CompanyHasFactoryMakeTransactionForm(TblFactory factory,TblCompanyHasFactory companyHasFactory)
        {
            InitializeComponent();
            this.companyHasFactory = companyHasFactory;
            this.factory = factory;
        }
    }
}
