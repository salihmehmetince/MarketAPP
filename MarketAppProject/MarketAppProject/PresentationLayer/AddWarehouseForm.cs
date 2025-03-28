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
    public partial class AddWarehouseForm : Form
    {
        public AddWarehouseForm()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string warehouseName = TxtWarehouseName.Text;
            string warehouseAddress = RTBAddress.Text;
            string phoneNumber = MTBPhoneNumber.Text;
            string email = TxtWarehouseEmail.Text;

            TblWarehouse warehouse = new TblWarehouse();
            warehouse.warehouseName = warehouseName;
            warehouse.warehouseAddress = warehouseAddress;
            warehouse.warehouseTelephoneNumber = phoneNumber;
            warehouse.warehouseEmail = email;

            WarehouseManager warehouseManager = new WarehouseManager();
            int result = warehouseManager.BLWarehouseAdd(warehouse);
            if (result > 0)
            {
                MessageBox.Show("Successfully saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
