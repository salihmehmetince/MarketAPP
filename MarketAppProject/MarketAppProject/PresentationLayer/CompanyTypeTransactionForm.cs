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
    public partial class CompanyTypeTransactionForm : Form
    {
        private Panel topPanel;
        private Button btnAdd;
        private Button btnList;
        public CompanyTypeTransactionForm()
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

        private void CompanyTypeTransactionForm_Load(object sender, EventArgs e)
        {
            LoadCompanyTypes();
        }

        private void LoadCompanyTypes()
        {
            flowLayoutPanel1.Controls.Clear();
            CompanyTypeManager companyTypeManager = new CompanyTypeManager();
            List<TblCompanyType> companyTypes = companyTypeManager.BLCompanyTypeList();

            if (companyTypes == null || companyTypes.Count == 0)
            {
                MessageBox.Show("There aren't any records", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (TblCompanyType companyType in companyTypes)
            {
                // Grup Kutusu (Kutu Şekilli Profesyonel Alan)
                GroupBox groupBox = new GroupBox
                {
                    Text = companyType.companyTypeName,
                    Width = 280,
                    Height = 120,
                    BackColor = Color.LightSalmon,
                    Font = new Font("Times New Roman", 10, FontStyle.Bold),
                    Padding = new Padding(10)
                };

                Label lblCompanyType = new Label
                {
                    Text = $"Company Type: {companyType.companyTypeName}",
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
                    Tag = companyType
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
                    Tag = companyType
                };
                btnDelete.FlatAppearance.BorderSize = 0;
                btnDelete.Click += BtnDelete_Click;

                groupBox.Controls.Add(lblCompanyType);
                groupBox.Controls.Add(btnUpdate);
                groupBox.Controls.Add(btnDelete);

                flowLayoutPanel1.Controls.Add(groupBox);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is TblCompanyType companType)
            {
                UpdateCompanyTypeForm updateCompanyTypeForm = new UpdateCompanyTypeForm(companType);
                updateCompanyTypeForm.ShowDialog();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is TblCompanyType companType)
            {
                DialogResult result = MessageBox.Show($"Do you want to delete {companType.companyTypeName}?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    CompanyTypeManager companyTypeManager = new CompanyTypeManager();
                    int result2 = companyTypeManager.BLCompanyTypeDelete(companType);
                    if (result2 > 0)
                    {
                        MessageBox.Show($"{companType.companyTypeName} deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCompanyTypes();
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
            AddCompanyTypeForm form = new AddCompanyTypeForm();
            form.ShowDialog();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            LoadCompanyTypes();
        }
    }
}
