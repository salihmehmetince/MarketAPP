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
    public partial class UpdateWarehouseForm : Form
    {

        private TblWarehouse warehouse;
        public UpdateWarehouseForm(TblWarehouse warehouse)
        {
            this.warehouse = warehouse;
            InitializeComponent();
        }
    }
}
