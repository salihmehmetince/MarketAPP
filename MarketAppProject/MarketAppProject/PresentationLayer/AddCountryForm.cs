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
    public partial class AddCountryForm : Form
    {
        public AddCountryForm()
        {
            InitializeComponent();
        }

        private void BtnSaveCountry_Click(object sender, EventArgs e)
        {
            string countryName=TxtCountryName.Text;
            string countryProductionCode=TxtCountryProductionCode.Text;
            TblCountry country = new TblCountry();
            country.countryName = countryName;
            country.countryProductionCode = countryProductionCode;
            CountryManager countryManager = new CountryManager();
            int result=countryManager.BLCountryAdd(country);
            if(result>0)
            {
                MessageBox.Show("Successfully saved","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
