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
    public partial class UpdateMarketForm : Form
    {
        private TblMarket market;
        public UpdateMarketForm(TblMarket market)
        {
            this.market = market;
            InitializeComponent();
        }

        private void BtnUpdateMarket_Click(object sender, EventArgs e)
        {
            string marketName = TxtmarketName.Text;
            string marketAddress = RTBAddress.Text;
            string phoneNumber = MTBPhoneNumber.Text;
            string email = TxtmarketEmail.Text;

            market.marketName = marketName;
            market.marketAddress = marketAddress;
            market.marketTelephoneNumber = phoneNumber;
            market.marketEmail = email;

            MarketManager marketManager = new MarketManager();
            int result = marketManager.BLMarketUpdate(market);
            if (result > 0)
            {
                MessageBox.Show("Successfully updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateMarketForm_Load(object sender, EventArgs e)
        {
            TxtmarketName.Text = market.marketName;
            RTBAddress.Text = market.marketAddress;
            MTBPhoneNumber.Text = market.marketTelephoneNumber;
            TxtmarketEmail.Text = market.marketEmail;
        }
    }
}
