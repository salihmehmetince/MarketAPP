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
    public partial class MarketTransactionsForm : Form
    {
        private Panel topPanel;
        private Button btnAdd;
        private Button btnList;
        public MarketTransactionsForm()
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
                BackColor = Color.DarkMagenta,
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

        private void MarketTransactionsForm_Load(object sender, EventArgs e)
        {
            LoadMarkets();
        }

        private void LoadMarkets()
        {
            flowLayoutPanel1.Controls.Clear();
            MarketManager marketManager = new MarketManager();
            List<TblMarket> markets = marketManager.BLMarketList();

            if (markets == null || markets.Count == 0)
            {
                MessageBox.Show("There aren't any records", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (TblMarket market in markets)
            {
                // Grup Kutusu (Kutu Şekilli Profesyonel Alan)
                GroupBox groupBox = new GroupBox
                {
                    Text = market.marketName,
                    Width = 280,
                    Height = 120,
                    BackColor = Color.LightBlue,
                    Font = new Font("Times New Roman", 10, FontStyle.Bold),
                    Padding = new Padding(10)
                };

                Label lblMarket = new Label
                {
                    Text = $"Market: {market.marketName}",
                    Location = new Point(10, 20),
                    AutoSize = true
                };

                // Güncelleme Butonu
                Button btnUpdate = new Button
                {
                    Text = "Update",
                    Size = new Size(85, 35),
                    Location = new Point(10, 60),
                    BackColor = Color.DarkGray,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Tag = market
                };
                btnUpdate.FlatAppearance.BorderSize = 0;
                btnUpdate.Click += BtnUpdate_Click;

                // Silme Butonu
                Button btnDelete = new Button
                {
                    Text = "Delete",
                    Size = new Size(85, 35),
                    Location = new Point(100, 60),
                    BackColor = Color.Brown,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Tag = market
                };
                btnDelete.FlatAppearance.BorderSize = 0;
                btnDelete.Click += BtnDelete_Click;

                groupBox.Controls.Add(lblMarket);
                groupBox.Controls.Add(btnUpdate);
                groupBox.Controls.Add(btnDelete);

                flowLayoutPanel1.Controls.Add(groupBox);
            }

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is TblMarket market)
            {
                UpdateMarketForm updateMarketForm = new UpdateMarketForm(market);
                updateMarketForm.ShowDialog();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is TblMarket market)
            {
                DialogResult result = MessageBox.Show($"Do you want to delete {market.marketName}?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    MarketHasEmployeeManager marketHasEmployeeManager = new MarketHasEmployeeManager();
                    List<TblMarketHasEmployee> marketHasEmployees = marketHasEmployeeManager.BLMarketHasEmployeeList().Where(c => c.marketId == market.marketId).ToList();
                    foreach (TblMarketHasEmployee marketHasEmployee in marketHasEmployees)
                    {
                        marketHasEmployeeManager.BLMarketHasEmployeeDelete(marketHasEmployee);
                    }

                    MarketHasVehicleManager marketHasVehicleManager = new MarketHasVehicleManager();
                    List<TblMarketHasVehicle> marketHasVehicles = marketHasVehicleManager.BLMarketHasVehicleList().Where(c => c.marketId == market.marketId).ToList();
                    foreach (TblMarketHasVehicle marketHasVehicle in marketHasVehicles)
                    {
                        marketHasVehicleManager.BLMarketHasVehicleDelete(marketHasVehicle);
                    }


                    MarketHasEquipmentManager marketHasEquipmentManager = new MarketHasEquipmentManager();
                    List<TblMarketHasEquipment> marketHasEquipments = marketHasEquipmentManager.BLMarketHasEquipmentList().Where(c => c.marketId == market.marketId).ToList();
                    foreach (TblMarketHasEquipment marketHasEquipment in marketHasEquipments)
                    {
                        marketHasEquipmentManager.BLMarketHasEquipmentDelete(marketHasEquipment);
                    }



                    MarketInventoryManager marketInventoryManager = new MarketInventoryManager();
                    List<TblMarketInventory> marketInventories = marketInventoryManager.BLMarketInventoryList().Where(c => c.marketId == market.marketId).ToList();
                    foreach (TblMarketInventory marketInventory in marketInventories)
                    {
                        marketInventoryManager.BLMarketInventoryDelete(marketInventory);
                    }



                    MarketManager marketManager = new MarketManager();
                    int result2 = marketManager.BLMarketDelete(market);
                    if (result2 > 0)
                    {
                        MessageBox.Show($"{market.marketName} deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadMarkets();
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
            AddMarketForm form = new AddMarketForm();
            form.ShowDialog();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            LoadMarkets();
        }

    }
}
