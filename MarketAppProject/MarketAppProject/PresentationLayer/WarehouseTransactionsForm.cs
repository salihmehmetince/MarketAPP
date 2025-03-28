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
    public partial class WarehouseTransactionsForm : Form
    {
        private Panel topPanel;
        private Button btnAdd;
        private Button btnList;
        public WarehouseTransactionsForm()
        {
            InitializeComponent();
            topPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 60,
                Padding = new Padding(10),
                BackColor = Color.LightSlateGray
            };

            // Ekle Butonu
            btnAdd = new Button
            {
                Text = "Add",
                Size = new Size(120, 40),
                Location = new Point(10, 10),
                BackColor = Color.DarkBlue,
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

        private void WarehouseTransactionsForm_Load(object sender, EventArgs e)
        {
            LoadWarehouses();
        }

        private void LoadWarehouses()
        {
            flowLayoutPanel1.Controls.Clear();
            WarehouseManager warehouseManager = new WarehouseManager();
            List<TblWarehouse> warehouses = warehouseManager.BLWarehouseList();

            if (warehouses == null || warehouses.Count == 0)
            {
                MessageBox.Show("There aren't any records", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (TblWarehouse warehouse in warehouses)
            {
                // Grup Kutusu (Kutu Şekilli Profesyonel Alan)
                GroupBox groupBox = new GroupBox
                {
                    Text = warehouse.warehouseName,
                    Width = 280,
                    Height = 120,
                    BackColor = Color.LightBlue,
                    Font = new Font("Times New Roman", 10, FontStyle.Bold),
                    Padding = new Padding(10)
                };

                Label lblWarehouse = new Label
                {
                    Text = $"Warehouse: {warehouse.warehouseName}",
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
                    Tag = warehouse
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
                    Tag = warehouse
                };
                btnDelete.FlatAppearance.BorderSize = 0;
                btnDelete.Click += BtnDelete_Click;

                groupBox.Controls.Add(lblWarehouse);
                groupBox.Controls.Add(btnUpdate);
                groupBox.Controls.Add(btnDelete);

                flowLayoutPanel1.Controls.Add(groupBox);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is TblWarehouse warehouse)
            {
                UpdateWarehouseForm updateWarehouseForm = new UpdateWarehouseForm(warehouse);
                updateWarehouseForm.ShowDialog();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is TblWarehouse warehouse)
            {
                DialogResult result = MessageBox.Show($"Do you want to delete {warehouse.warehouseName}?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    WarehouseHasEmplyeeManager warehouseHasEmplyeeManager = new WarehouseHasEmplyeeManager();
                    List<TblWarehouseHasEmployee> warehouseHasEmployees = warehouseHasEmplyeeManager.BLWarehouseHasEmployeeList().Where(c => c.warehouseId == warehouse.warehouseId).ToList();
                    foreach (TblWarehouseHasEmployee warehouseHasEmployee in warehouseHasEmployees)
                    {
                        warehouseHasEmplyeeManager.BLWarehouseHasEmployeeDelete(warehouseHasEmployee);
                    }

                    WarehouseHasVehicleManager warehouseHasVehicleManager = new WarehouseHasVehicleManager();
                    List<TblWarehouseHasVehicle> warehouseHasVehicles = warehouseHasVehicleManager.BLWarehouseHasVehicleList().Where(c => c.warehouseId == warehouse.warehouseId).ToList();
                    foreach (TblWarehouseHasVehicle warehouseHasVehicle in warehouseHasVehicles)
                    {
                        warehouseHasVehicleManager.BLWarehouseHasVehicleDelete(warehouseHasVehicle);
                    }


                    WareHouseHasEquipmentManager wareHouseHasEquipmentManager = new WareHouseHasEquipmentManager();
                    List<TblWareHouseHasEquipment> wareHouseHasEquipments = wareHouseHasEquipmentManager.BLWarehouseHasEquipmentList().Where(c => c.warehouseId == warehouse.warehouseId).ToList();
                    foreach (TblWareHouseHasEquipment wareHouseHasEquipment in wareHouseHasEquipments)
                    {
                        wareHouseHasEquipmentManager.BLWarehouseHasEquipmentDelete(wareHouseHasEquipment);
                    }



                    WarehouseInventoryManager warehouseInventoryManager = new WarehouseInventoryManager();
                    List<TblWarehouseInventory> warehouseInventories = warehouseInventoryManager.BLWarehouseInventoryList().Where(c => c.warehouseId == warehouse.warehouseId).ToList();
                    foreach (TblWarehouseInventory warehouseInventory in warehouseInventories)
                    {
                        warehouseInventoryManager.BLWarehouseInventoryDelete(warehouseInventory);
                    }


                    WarehouseSendsToMarketManager warehouseSendsToMarketManager = new WarehouseSendsToMarketManager();
                    List<TblWarehouseSendsToMarket> warehouseSendsToMarkets = warehouseSendsToMarketManager.BLWarehouseSendsToMarketList().Where(c => c.warehouseId == warehouse.warehouseId).ToList();
                    foreach (TblWarehouseSendsToMarket warehouseSendsToMarket in warehouseSendsToMarkets)
                    {
                        warehouseSendsToMarketManager.BLWarehouseSendsToMarketDelete(warehouseSendsToMarket);
                    }

                    WarehouseManager warehouseManager = new WarehouseManager();
                    int result2 = warehouseManager.BLWarehouseDelete(warehouse);
                    if (result2 > 0)
                    {
                        MessageBox.Show($"{warehouse.warehouseName} deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadWarehouses();
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
            AddWarehouseForm form = new AddWarehouseForm();
            form.ShowDialog();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            LoadWarehouses();
        }
    }
}
