﻿using MarketAppProject.BusinessLogicLayer;
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
    public partial class CompanyTransactionsForm : Form
    {

        private Panel topPanel;
        private Button btnAdd;
        private Button btnList;
        public CompanyTransactionsForm()
        {
            InitializeComponent();

            topPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 60,
                Padding = new Padding(10),
                BackColor = Color.DarkGray
            };

            // Ekle Butonu
            btnAdd = new Button
            {
                Text = "Add",
                Size = new Size(120, 40),
                Location = new Point(10, 10),
                BackColor = Color.DodgerBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Click += BtnAdd_Click;

            // Listele Butonu
            btnList = new Button
            {
                Text = "List",
                Size = new Size(120, 40),
                Location = new Point(140, 10),
                BackColor = Color.Red,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnList.FlatAppearance.BorderSize = 0;
            btnList.Click += BtnList_Click;

            topPanel.Controls.Add(btnAdd);
            topPanel.Controls.Add(btnList);
            this.Controls.Add(topPanel);
        }

        private void BtnAddCompany_Click(object sender, EventArgs e)
        {
            DefineCompanyForm defineCompanyForm = new DefineCompanyForm();
            defineCompanyForm.ShowDialog();
        }

        private void CompanyTransactionsForm_Load(object sender, EventArgs e)
        {
            LoadCompanies();
        }

        private void LoadCompanies()
        {
            flowLayoutPanel1.Controls.Clear();
            CompanyManager companyManager = new CompanyManager();
            List<TblCompany> companies = companyManager.BLCompanyList();

            if (companies == null || companies.Count == 0)
            {
                MessageBox.Show("There aren't any records", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (TblCompany company in companies)
            {
                // Grup Kutusu (Kutu Şekilli Profesyonel Alan)
                GroupBox groupBox = new GroupBox
                {
                    Text = company.companyName,
                    Width = 280,
                    Height = 120,
                    BackColor = Color.YellowGreen,
                    Font = new Font("Times New Roman", 10, FontStyle.Bold),
                    Padding = new Padding(10)
                };

                Label lblCompanyName = new Label
                {
                    Text = $"Company Type: {company.companyName}",
                    Location = new Point(10, 20),
                    AutoSize = true
                };


                // Güncelleme Butonu
                Button btnUpdate = new Button
                {
                    Text = "Update",
                    Size = new Size(85, 35),
                    Location = new Point(10, 60),
                    BackColor = Color.LightSeaGreen,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Tag = company
                };
                btnUpdate.FlatAppearance.BorderSize = 0;
                btnUpdate.Click += BtnUpdate_Click;

                // Silme Butonu
                Button btnDelete = new Button
                {
                    Text = "Delete",
                    Size = new Size(85, 35),
                    Location = new Point(100, 60),
                    BackColor = Color.Purple,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Tag = company
                };
                btnDelete.FlatAppearance.BorderSize = 0;
                btnDelete.Click += BtnDelete_Click;

                groupBox.Controls.Add(lblCompanyName);
                groupBox.Controls.Add(btnUpdate);
                groupBox.Controls.Add(btnDelete);

                flowLayoutPanel1.Controls.Add(groupBox);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is TblCompany company)
            {
                UpdateCompanyForm updateCompanyForm = new UpdateCompanyForm();
                updateCompanyForm.ShowDialog();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is TblCompany company)
            {
                DialogResult result = MessageBox.Show($"Do you want to delete {company.companyName}?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    CompanyOwnerHasCompanyManager companyOwnerHasCompanyManager = new CompanyOwnerHasCompanyManager();
                    List<TblCompanyOwerHasCompany> companyOwerHasCompanies=companyOwnerHasCompanyManager.BLCompanyOwerHasCompanyList().Where(c=>c.company==company.companyId).ToList();
                    foreach (TblCompanyOwerHasCompany owerHasCompany in companyOwerHasCompanies) 
                    {
                        companyOwnerHasCompanyManager.BLCompanyOwerHasCompanyDelete(owerHasCompany);
                    }

                    CompanyHasFactoryManager companyHasFactoryManager = new CompanyHasFactoryManager();
                    List<TblCompanyHasFactory> companyHasFactories = companyHasFactoryManager.BLCompanyHasFactoryList().Where(c=>c.companyId==company.companyId).ToList();

                    foreach(TblCompanyHasFactory factory in companyHasFactories)
                    {
                        companyHasFactoryManager.BLCompanyHasFactoryDelete(factory);
                    }

                    CompanyHasMarketManager companyHasMarketManager = new CompanyHasMarketManager();
                    List<TblCompanyHasMarket> companyHasMarkets = companyHasMarketManager.BLCompanyHasMarketList().Where(c => c.companyId == company.companyId).ToList();
                    foreach(TblCompanyHasMarket companyHasMarket in companyHasMarkets)
                    {
                        companyHasMarketManager.BLCompanyHasMarketDelete(companyHasMarket);
                    }

                    CompanyHasWarehouseManager companyHasWarehouseManager=new CompanyHasWarehouseManager();
                    List<TblCompanyHasWarehouse> companyHasWarehouses = companyHasWarehouseManager.BLCompanyHasWarehouseList().Where(c=>c.companyId==company.companyId).ToList();

                    foreach(TblCompanyHasWarehouse companyHasWarehouse in companyHasWarehouses)
                    {
                        companyHasWarehouseManager.BLCompanyHasWarehouseDelete(companyHasWarehouse);
                    }
                    CompanyManager companyManager = new CompanyManager();
                    int result2 = companyManager.BLCompanyDelete(company);
                    if (result2 > 0)
                    {
                        MessageBox.Show($"{company.companyName} deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCompanies();
                    }
                    else
                    {
                        MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            DefineCompanyForm form = new DefineCompanyForm();
            form.ShowDialog();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            LoadCompanies();
        }
    }
}
