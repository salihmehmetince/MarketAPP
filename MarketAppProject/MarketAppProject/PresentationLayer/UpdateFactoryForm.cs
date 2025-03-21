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
    public partial class UpdateFactoryForm : Form
    {
        private TblFactory factory;
        public UpdateFactoryForm(TblFactory factory)
        {
            this.factory = factory;
            InitializeComponent();
        }

        private void UpdateFactoryForm_Load(object sender, EventArgs e)
        {
            CountryManager countryManager = new CountryManager();
            List<TblCountry> countries = countryManager.BLCountryList();
            CMBCountry.DataSource = countries;
            CMBCountry.DisplayMember = "countryName";
            CMBCountry.ValueMember = "countryId";

            TxtFactoryName.Text = factory.factoryName;
            RTBAddress.Text = factory.factoryAddress;
            MTBPhoneNumber.Text = factory.factoryTelephoneNumber;
            TxtEmail.Text = factory.factoryEmail;
            CMBCountry.SelectedValue = factory.factoryCountry;
            TxtFactoryproductionCode.Text = factory.factoryProductionCode;
        }

        private void BtnUpdateFactory_Click(object sender, EventArgs e)
        {
            string factoryName = TxtFactoryName.Text;
            string factoryAddress = RTBAddress.Text;
            string phoneNumber = MTBPhoneNumber.Text;
            string email = TxtEmail.Text;
            int country = Convert.ToInt32(CMBCountry.SelectedValue);
            string productionCode = TxtFactoryproductionCode.Text;
            factory.factoryName = factoryName;
            factory.factoryAddress = factoryAddress;
            factory.factoryTelephoneNumber = phoneNumber;
            factory.factoryEmail = email;
            factory.factoryCountry = country;
            factory.factoryProductionCode = productionCode;

            FactoryManager factoryManager = new FactoryManager();
            int result = factoryManager.BLFactoryUpdate(factory);
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
    }
}
