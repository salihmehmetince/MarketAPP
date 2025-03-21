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
    public partial class FactoryTransactionForm : Form
    {
        private Panel topPanel;
        private Button btnAdd;
        private Button btnList;

        public FactoryTransactionForm()
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

        private void FactoryTransactionForm_Load(object sender, EventArgs e)
        {
            LoadFactories();
        }

        private void LoadFactories()
        {
            flowLayoutPanel1.Controls.Clear();
            FactoryManager factoryManager = new FactoryManager();
            List<TblFactory> factories = factoryManager.BLFactoryList();

            if (factories == null || factories.Count == 0)
            {
                MessageBox.Show("There aren't any records", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (TblFactory factory in factories)
            {
                // Grup Kutusu (Kutu Şekilli Profesyonel Alan)
                GroupBox groupBox = new GroupBox
                {
                    Text = factory.factoryName,
                    Width = 280,
                    Height = 120,
                    BackColor = Color.LightBlue,
                    Font = new Font("Times New Roman", 10, FontStyle.Bold),
                    Padding = new Padding(10)
                };

                Label lblFactory = new Label
                {
                    Text = $"Factory: {factory.factoryName}",
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
                    Tag = factory
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
                    Tag = factory
                };
                btnDelete.FlatAppearance.BorderSize = 0;
                btnDelete.Click += BtnDelete_Click;

                groupBox.Controls.Add(lblFactory);
                groupBox.Controls.Add(btnUpdate);
                groupBox.Controls.Add(btnDelete);

                flowLayoutPanel1.Controls.Add(groupBox);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is TblFactory factory)
            {
                UpdateFactoryForm updateFactoryForm = new UpdateFactoryForm(factory);
                updateFactoryForm.ShowDialog();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is TblFactory factory)
            {
                DialogResult result = MessageBox.Show($"Do you want to delete {factory.factoryName}?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    FactoryHasEmployeeManager factoryHasEmployeeManager = new FactoryHasEmployeeManager();
                    List<TblFactoryHasEmployee> factoryHasEmployees=factoryHasEmployeeManager.BLFactoryHasEmployeeList().Where(c=>c.factoryId==factory.factoryId).ToList();
                    foreach(TblFactoryHasEmployee factoryHasEmployee in factoryHasEmployees)
                    {
                        factoryHasEmployeeManager.BLFactoryHasEmployeeDelete(factoryHasEmployee);
                    }

                    FactoryHasVehicleManager factoryHasVehicleManager = new FactoryHasVehicleManager();
                    List<TblFactoryHasVehicle> factoryHasVehicles=factoryHasVehicleManager.BLFactoryHasVehicleList().Where(c => c.factoryId == factory.factoryId).ToList();
                    foreach(TblFactoryHasVehicle factoryHasVehicle in factoryHasVehicles)
                    {
                        factoryHasVehicleManager.BLFactoryHasVehicleDelete(factoryHasVehicle);
                    }
                    

                    FactoryHasEquipmentManager factoryHasEquipmentManager = new FactoryHasEquipmentManager();
                    List<TblFactoryHasEquipment> factoryHasEquipments=factoryHasEquipmentManager.BLFactoryHasEquipmentList().Where(c => c.factoryId == factory.factoryId).ToList();
                    foreach(TblFactoryHasEquipment factoryHasEquipment in factoryHasEquipments)
                    {
                        factoryHasEquipmentManager.BLFactoryHasEquipmentDelete(factoryHasEquipment);
                    }
                    
                    

                    FactoryInventoryManager factoryInventoryManager = new FactoryInventoryManager();
                    List<TblFactoryInventory> factoryInventories=factoryInventoryManager.BLFactoryInventoryList().Where(c => c.factoryId == factory.factoryId).ToList();
                    foreach(TblFactoryInventory factoryInventory in factoryInventories)
                    {
                        factoryInventoryManager.BLFactoryInventoryDelete(factoryInventory);
                    }
                    
                    FactoryProducedProductManager factoryProducedProductManager = new FactoryProducedProductManager();
                    List<TblFactoryProducedProduct> factoryProducedProducts= factoryProducedProductManager.BLFactoryProducedProductList().Where(c => c.factoryId == factory.factoryId).ToList();
                    foreach(TblFactoryProducedProduct factoryProducedProduct in factoryProducedProducts)
                    {
                        factoryProducedProductManager.BLFactoryProducedProductDelete(factoryProducedProduct);
                    }
                    
                    FactoryProductProductionManager factoryProductProductionManager = new FactoryProductProductionManager();
                    List<TblFactoryProductProduction> factoryProductProductions= factoryProductProductionManager.BLFactoryProductProductionList().Where(c => c.factoryId == factory.factoryId).ToList();
                    foreach(TblFactoryProductProduction factoryProductProduction in factoryProductProductions)
                    {
                        factoryProductProductionManager.BLFactoryProductProductionDelete(factoryProductProduction);
                    }
                    
                    FactorySendsProductToMarketManager factorySendsProductToMarketManager = new FactorySendsProductToMarketManager();
                    List<TblFactorySendsProductToMarket> factorySendsProductToMarkets= factorySendsProductToMarketManager.BLFactorySendsProductToMarketList().Where(c => c.factoryId == factory.factoryId).ToList();
                    foreach(TblFactorySendsProductToMarket factorySendsProductToMarket in factorySendsProductToMarkets)
                    {
                        factorySendsProductToMarketManager.BLFactorySendsProductToMarketDelete(factorySendsProductToMarket);
                    }
                    
                    FactorySendsProductToWarehouseManager factorySendsProductToWarehouseManager = new FactorySendsProductToWarehouseManager();
                    List<TblFactorySendsProductToWarehouse> factorySendsProductToWarehouses= factorySendsProductToWarehouseManager.BLFactorySendsProductToWarehouseList().Where(c => c.factoryId == factory.factoryId).ToList();
                    foreach(TblFactorySendsProductToWarehouse factorySendsProductToWarehouse in factorySendsProductToWarehouses)
                    {
                        factorySendsProductToWarehouseManager.BLFactorySendsProductToWarehouseDelete(factorySendsProductToWarehouse);
                    }

                    FactoryManager factoryManager = new FactoryManager();
                    int result2 = factoryManager.BLFactoryDelete(factory);
                    if (result2 > 0)
                    {
                        MessageBox.Show($"{factory.factoryName} deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadFactories();
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
            AddFactoryForm form = new AddFactoryForm();
            form.ShowDialog();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            LoadFactories();
        }
    }
}
