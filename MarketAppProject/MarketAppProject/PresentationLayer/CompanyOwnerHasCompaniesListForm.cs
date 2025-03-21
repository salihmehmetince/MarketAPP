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
                                                      where cOHC.companyOwner == companyOwner.companyOwnerId && cOHC.isActive == true
                                                      select company)
                                                      .ToList();
            CreateCompanyGroupBoxes(companyOwnerCompanies);
        }

        private void CreateCompanyGroupBoxes(List<TblCompany> companyOwnerCompanies)
        {
            this.Controls.OfType<GroupBox>().ToList().ForEach(gb => this.Controls.Remove(gb));

            int startX = 50;
            int startY = 100;
            int groupBoxWidth = 200;
            int groupBoxHeight = 100;
            int horizontalSpacing = 20; // Sütunlar arası boşluk
            int verticalSpacing = 20;   // Satırlar arası boşluk
            int columns = 5; // Kaç sütun olacağını belirliyoruz

            for (int i = 0; i < companyOwnerCompanies.Count; i++)
            {
                int index = i; // Local değişken oluştur

                int column = index % columns; // 4 sütun olacak, her 4 öğede bir sıfırlanır
                int row = index / columns;    // Her 4 öğede bir yeni satıra geçer

                // GroupBox oluştur
                GroupBox groupBox = new GroupBox();
                groupBox.Text = "Company";
                groupBox.Size = new Size(groupBoxWidth, groupBoxHeight);
                groupBox.Location = new Point(startX + column * (groupBoxWidth + horizontalSpacing),
                                              startY + row * (groupBoxHeight + verticalSpacing));

                // Label oluştur (Şirket adı)
                Label lblCompanyName = new Label();
                lblCompanyName.Text = companyOwnerCompanies[index].companyName;
                lblCompanyName.AutoSize = true;
                lblCompanyName.Location = new Point(10, 20);
                lblCompanyName.Font = new Font("Times New Roman", 10, FontStyle.Bold);

                // Button oluştur (İşlem Yap)
                Button btnTransaction = new Button();
                btnTransaction.Text = "Make Transaction";
                btnTransaction.Size = new Size(150, 30);
                btnTransaction.Location = new Point(10, 50);
                btnTransaction.BackColor = Color.LightBlue;
                btnTransaction.FlatStyle = FlatStyle.Flat;

                btnTransaction.Tag = companyOwnerCompanies[i]; // Butona şirket bilgisini ata

                btnTransaction.Click += (s, e) =>
                {
                    Button clickedButton = (Button)s;
                    TblCompany company = (TblCompany)clickedButton.Tag; // Butondan şirketi al

                    CompanyOwnerHasCompanyManager companyOwnerHasCompanyManager = new CompanyOwnerHasCompanyManager();
                    TblCompanyOwerHasCompany companyOwerHasCompany = companyOwnerHasCompanyManager
                        .BLCompanyOwerHasCompanyList()
                        .FirstOrDefault(c => c.company == company.companyId && c.companyOwner == companyOwner.companyOwnerId);

                    CompanyOwnerCompanyMakeTransactionForm transactionForm = new CompanyOwnerCompanyMakeTransactionForm(
                        companyOwner, company, companyOwerHasCompany);
                    transactionForm.ShowDialog();
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
            CompanyOwnerBuyCompanyForm form = new CompanyOwnerBuyCompanyForm(companyOwner);
            form.ShowDialog();
        }

        private void BtnListCompanies_Click(object sender, EventArgs e)
        {
            CompanyOwnerHasCompaniesListForm_Load(sender, e);
        }

    }
}
