﻿using System;
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
    public partial class AdminTransactionsForm : Form
    {
        public AdminTransactionsForm()
        {
            InitializeComponent();
        }

        private void BtnProfession_Click(object sender, EventArgs e)
        {
            ProfessionTransactionForm professionTransactionForm = new ProfessionTransactionForm();  
            professionTransactionForm.ShowDialog();
        }

        private void BtnCountry_Click(object sender, EventArgs e)
        {
            CountryTransactionForm countryTransactionForm = new CountryTransactionForm();
            countryTransactionForm.ShowDialog();
        }

        private void BtnCompanyType_Click(object sender, EventArgs e)
        {
            CompanyTypeTransactionForm companyTypeTransactionForm = new CompanyTypeTransactionForm();
            companyTypeTransactionForm.ShowDialog();
        }
    }
}
