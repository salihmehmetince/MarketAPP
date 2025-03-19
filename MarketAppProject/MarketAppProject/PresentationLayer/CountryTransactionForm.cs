using MarketAppProject.BusinessLogicLayer;
using MarketAppProject.DataAccessLayer;
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
    public partial class CountryTransactionForm : Form
    {
        private Panel topPanel;
        private Button btnAdd;
        private Button btnList;
        public CountryTransactionForm()
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

        private void CountryTransactionForm_Load(object sender, EventArgs e)
        {
            LoadCountryies();
        }

        private void LoadCountryies()
        {
            flowLayoutPanel1.Controls.Clear();
            CountryManager countryManager = new CountryManager();
            List<TblCountry> countries = countryManager.BLCountryList();

            if (countries == null || countries.Count == 0)
            {
                MessageBox.Show("There aren't any records", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (TblCountry country in countries) 
            {
                // Grup Kutusu (Kutu Şekilli Profesyonel Alan)
                GroupBox groupBox = new GroupBox
                {
                    Text = country.countryName,
                    Width = 280,
                    Height = 120,
                    BackColor = Color.LightGray,
                    Font = new Font("Times New Roman", 10, FontStyle.Bold),
                    Padding = new Padding(10)
                };

                Label LblCountryName = new Label
                {
                    Text = $"Country Name: {country.countryName}",
                    Location = new Point(10, 20),
                    AutoSize = true
                };

                Label LblCountryProductionCode = new Label
                {
                    Text = $"Country Production Code: {country.countryProductionCode}",
                    Location = new Point(10, 40),
                    AutoSize = true
                };

                // Güncelleme Butonu
                Button btnUpdate = new Button
                {
                    Text = "Update",
                    Size = new Size(85, 35),
                    Location = new Point(10, 60),
                    BackColor = Color.Purple,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Tag = country
                };
                btnUpdate.FlatAppearance.BorderSize = 0;
                btnUpdate.Click += BtnUpdate_Click;

                // Silme Butonu
                Button btnDelete = new Button
                {
                    Text = "Delete",
                    Size = new Size(85, 35),
                    Location = new Point(100, 60),
                    BackColor = Color.Black,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Tag = country
                };
                btnDelete.FlatAppearance.BorderSize = 0;
                btnDelete.Click += BtnDelete_Click;

                groupBox.Controls.Add(LblCountryName);
                groupBox.Controls.Add(LblCountryProductionCode);
                groupBox.Controls.Add(btnUpdate);
                groupBox.Controls.Add(btnDelete);

                flowLayoutPanel1.Controls.Add(groupBox);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is TblCountry country)
            {
                UpdateCountryForm updateCountryForm = new UpdateCountryForm(country);
                updateCountryForm.ShowDialog();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is TblCountry country)
            {
                DialogResult result = MessageBox.Show($"Do you want to delete {country.countryName}?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    CountryManager countryManager = new CountryManager();
                    int result2 = countryManager.BLCountryDelete(country);
                    if (result2 > 0)
                    {
                        MessageBox.Show($"{country.countryName} deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCountryies();
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
            AddCountryForm addCountryForm = new AddCountryForm();
            addCountryForm.ShowDialog();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            LoadCountryies();
        }
    }
}
