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
    public partial class ProfessionTransactionForm : Form
    {
        private Panel topPanel;
        private Button btnAdd;
        private Button btnList;
        public ProfessionTransactionForm()
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
                BackColor = Color.SeaGreen,
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
                BackColor = Color.SteelBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnList.FlatAppearance.BorderSize = 0;
            btnList.Click += BtnList_Click;

            topPanel.Controls.Add(btnAdd);
            topPanel.Controls.Add(btnList);
            this.Controls.Add(topPanel);
        }

        private void ProfessionTransactionForm_Load(object sender, EventArgs e)
        {
            LoadProfessions();
        }

        private void LoadProfessions()
        {
            flowLayoutPanel1.Controls.Clear();
            ProfessionManager professionManager = new ProfessionManager();
            List<TblProfession> professions = professionManager.BLProfessionList();

            if (professions == null || professions.Count == 0)
            {
                MessageBox.Show("There aren't any records", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (TblProfession profession in professions)
            {
                // Grup Kutusu (Kutu Şekilli Profesyonel Alan)
                GroupBox groupBox = new GroupBox
                {
                    Text = profession.professionName,
                    Width = 280,
                    Height = 120,
                    BackColor = Color.LightGray,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    Padding = new Padding(10)
                };

                Label lblProfession = new Label
                {
                    Text = $"Profession: {profession.professionName}",
                    Location = new Point(10, 20),
                    AutoSize = true
                };

                // Güncelleme Butonu
                Button btnUpdate = new Button
                {
                    Text = "Update",
                    Size = new Size(85, 35),
                    Location = new Point(10, 60),
                    BackColor = Color.Orange,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Tag = profession
                };
                btnUpdate.FlatAppearance.BorderSize = 0;
                btnUpdate.Click += BtnUpdate_Click;

                // Silme Butonu
                Button btnDelete = new Button
                {
                    Text = "Delete",
                    Size = new Size(85, 35),
                    Location = new Point(100, 60),
                    BackColor = Color.Crimson,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Tag = profession
                };
                btnDelete.FlatAppearance.BorderSize = 0;
                btnDelete.Click += BtnDelete_Click;

                groupBox.Controls.Add(lblProfession);
                groupBox.Controls.Add(btnUpdate);
                groupBox.Controls.Add(btnDelete);

                flowLayoutPanel1.Controls.Add(groupBox);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is TblProfession profession)
            {
                UpdateProfessionForm updateProfessionForm = new UpdateProfessionForm(profession);
                updateProfessionForm.ShowDialog();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is TblProfession profession)
            {
                DialogResult result = MessageBox.Show($"Do you want to delete {profession.professionName}?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    ProfessionManager professionManager = new ProfessionManager();
                    int result2 = professionManager.BLProfessionDelete(profession);
                    if (result2 > 0)
                    {
                        MessageBox.Show($"{profession.professionName} deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProfessions();
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
            AddProfessionForm form = new AddProfessionForm();
            form.ShowDialog();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            LoadProfessions();
        }
    }
}

