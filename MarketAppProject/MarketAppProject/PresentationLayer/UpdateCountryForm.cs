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
    public partial class UpdateCountryForm : Form
    {
        private TblCountry country;
        public UpdateCountryForm(TblCountry country)
        {
            this.country = country;
            InitializeComponent();
        }

        private void BtnUpdateCountry_Click(object sender, EventArgs e)
        {
            string countryName = TxtCountryName.Text;
            string countryProductionCode = TxtCountryProductionCode.Text;
            CountryManager countryManager = new CountryManager();
            country.countryName = countryName;
            country.countryProductionCode = countryProductionCode;
            int result = countryManager.BLCountryUpdate(country);
            if (result > 0)
            {
                MessageBox.Show("Successfully updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateCountryForm_Load(object sender, EventArgs e)
        {
            TxtCountryName.Text=country.countryName;
            TxtCountryProductionCode.Text=country.countryProductionCode;
        }
    }
}
