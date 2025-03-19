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
    public partial class CompanyOwnerRegisterForm : Form
    {
        public CompanyOwnerRegisterForm()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string identityNumber=TxtIdentityNumber.Text;
            string name=TxtName.Text;
            string surname=TxtSurname.Text;
            string email=TxtEmail.Text;
            string password=TxtPassword.Text;
            string phoneNumber=MTBPhoneNumber.Text;
            string gender = "M";
            if (RBMale.Checked == true) 
            {
                gender = "M";
            }
            else
            {
                gender = "F";
            }

            DateTime birthDate = DTPBirthDate.Value;
            int profession = Convert.ToInt32(CMBProfession.SelectedValue);
            string birthPlace = RTBBirthPlace.Text;
            string address=RTBAddress.Text;
            TblCompanyOwner companyOwner= new TblCompanyOwner();
            companyOwner.companyOwnerIdentityNumber = identityNumber;
            companyOwner.companyOwnerName = name;
            companyOwner.companyOwnerSurname = surname;
            companyOwner.companyOwnerEmail = email;
            companyOwner.companyOwnerPassword = password;
            companyOwner.companyOwnerTelephoneNumber = phoneNumber;
            companyOwner.companyOwnerGender = gender;
            companyOwner.companyOwnerBirthDate = birthDate;
            companyOwner.companyOwnerProfession = profession;
            companyOwner.companyOwnerBirthPlace = birthPlace;
            companyOwner.companyOwnerAddress = address;
            CompanyOwnerManager companyOwnerManager = new CompanyOwnerManager();
            int result=companyOwnerManager.BLCompanyOwnerAdd(companyOwner);
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

        private void CompanyOwnerRegisterForm_Load(object sender, EventArgs e)
        {
            ProfessionManager professionManager = new ProfessionManager();
            List<TblProfession> professions = professionManager.BLProfessionList();
            CMBProfession.DataSource = professions;
            CMBProfession.DisplayMember = "professionName";
            CMBProfession.ValueMember = "professionId";
        }
    }
}
