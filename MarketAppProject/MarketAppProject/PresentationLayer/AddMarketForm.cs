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
    public partial class AddMarketForm : Form
    {
        public AddMarketForm()
        {
            InitializeComponent();
        }

        private void AddMarketForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnSaveMarket_Click(object sender, EventArgs e)
        {
            string marketName=TxtmarketName.Text;
            string marketAddress=RTBAddress.Text;
            string phoneNumber=MTBPhoneNumber.Text;
            string email=TxtmarketEmail.Text;

            TblMarket market = new TblMarket();
            market.marketName = marketName;
            market.marketAddress = marketAddress;
            market.marketTelephoneNumber = phoneNumber;
            market.marketEmail = email;

            MarketManager marketManager = new MarketManager();
            int result = marketManager.BLMarketAdd(market);
            if(result>0)
            {
                MessageBox.Show("Successfully saved","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
