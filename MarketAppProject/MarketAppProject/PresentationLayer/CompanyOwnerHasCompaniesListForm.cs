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
    public partial class CompanyOwnerHasCompaniesListForm : Form
    {
        private TblCompanyOwner companyOwner;
        public CompanyOwnerHasCompaniesListForm(TblCompanyOwner companyOwner)
        {
            InitializeComponent();
            this.companyOwner = companyOwner;
        }

        private void CompanyOwnerHasCompaniesListForm_Load(object sender, EventArgs e)
        {
            CompanyManager companyManager = new CompanyManager();
            CompanyOwnerHasCompanyManager companyOwnerHasCompanyManager = new CompanyOwnerHasCompanyManager();
            List<TblCompany> companies = companyManager.BLCompanyList();
            List<TblCompanyOwerHasCompany> companyOwerHasCompanies=companyOwnerHasCompanyManager.BLCompanyOwerHasCompanyList();

            List<TblCompany> companyOwnerCompanies = (from company in companies
                                                      join cOHC in companyOwerHasCompanies
                                                      on company.companyId equals cOHC.company
                                                      where cOHC.companyOwner == companyOwner.companyOwnerId
                                                      select company)
                                                      .ToList();
            CreateCompanyGroupBoxes(companyOwnerCompanies);
        }

        private void CreateCompanyGroupBoxes(List<TblCompany> companyOwnerCompanies)
        {
            int startX = 500;
            int startY = 50;
            int groupBoxWidth = 200;
            int groupBoxHeight = 100;
            int verticalSpacing = 20;

            for (int i = 0; i < companyOwnerCompanies.Count; i++)
            {
                // GroupBox oluştur
                GroupBox groupBox = new GroupBox();
                groupBox.Text = "Şirket";
                groupBox.Size = new Size(groupBoxWidth, groupBoxHeight);
                groupBox.Location = new Point(startX, startY + (i * (groupBoxHeight + verticalSpacing)));

                // Label oluştur (Şirket adı)
                Label lblCompanyName = new Label();
                lblCompanyName.Text = companyOwnerCompanies[i].companyName;
                lblCompanyName.AutoSize = true;
                lblCompanyName.Location = new Point(10, 20);
                lblCompanyName.Font = new Font("Arial", 10, FontStyle.Bold);

                // Button oluştur (İşlem Yap)
                Button btnTransaction = new Button();
                btnTransaction.Text = "Make Transaction";
                btnTransaction.Size = new Size(150, 30);
                btnTransaction.Location = new Point(10, 50);
                btnTransaction.BackColor = Color.LightBlue;
                btnTransaction.FlatStyle = FlatStyle.Flat;

                // Butona Click Event ekleme (Opsiyonel)
                btnTransaction.Click += (s, e) =>
                {
                    MessageBox.Show($"Transaction started for {companyOwnerCompanies[i].companyName}", "Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };

                // GroupBox içine bileşenleri ekle
                groupBox.Controls.Add(lblCompanyName);
                groupBox.Controls.Add(btnTransaction);

                // Form'a ekle
                this.Controls.Add(groupBox);
            }
        }

        private void BtnBuyCompany_Click(object sender, EventArgs e)
        {

        }
    }
}
