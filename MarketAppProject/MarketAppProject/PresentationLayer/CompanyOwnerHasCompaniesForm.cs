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
    public partial class CompanyOwnerHasCompaniesForm : Form
    {
        private TblCompanyOwner companyOwner;
        public CompanyOwnerHasCompaniesForm(TblCompanyOwner companyOwner)
        {
            InitializeComponent();
            this.companyOwner = companyOwner;
        }

        private void CompanyOwnerHasCompaniesForm_Load(object sender, EventArgs e)
        {
            CompanyManager companyManager = new CompanyManager();   
            CompanyOwnerManager companyOwnerManager = new CompanyOwnerManager();
            CompanyOwnerHasCompanyManager companyOwnerHasCompanyManager = new CompanyOwnerHasCompanyManager();
            List<TblCompany> companies = companyManager.BLCompanyList();
            List<TblCompanyOwerHasCompany> companyOwerHasCompanies=companyOwnerHasCompanyManager.BLCompanyOwerHasCompanyList();
            List<TblCompany> companyOwnerCompanies = (from company in companies
                                                      join companyOwnerHasCompany in companyOwerHasCompanies
                                                      on company.companyId equals companyOwnerHasCompany.company
                                                      where companyOwnerHasCompany.companyOwner == companyOwner.companyOwnerId
                                                      select company).ToList();

            // Şirketler için dinamik panel oluşturma
            for (int i = 0; i < companyOwnerCompanies.Count; i++)
            {
                // Yeni bir panel oluştur
                Panel companyPanel = new Panel();
                companyPanel.Size = new Size(300, 100); // Panelin boyutunu belirleyin
                companyPanel.Location = new Point(10, 110 * i); // Panelin formda konumunu belirleyin

                // Şirket adı için bir Label oluştur
                Label companyNameLabel = new Label();
                companyNameLabel.Text = "Şirket Adı: " + companyOwnerCompanies[i].companyName; // Şirket adını etiket olarak ayarlayın
                companyNameLabel.Location = new Point(10, 10); // Label konumunu belirleyin
                companyPanel.Controls.Add(companyNameLabel); // Label'ı panellere ekleyin

                // İşlem butonları için 3 buton oluştur
                Button button1 = new Button();
                button1.Text = "İşlem 1";
                button1.Location = new Point(10, 40); // Buton konumunu belirleyin
                button1.Size = new Size(75, 30); // Buton boyutunu belirleyin
                companyPanel.Controls.Add(button1); // Buton 1'i ekleyin

                Button button2 = new Button();
                button2.Text = "İşlem 2";
                button2.Location = new Point(90, 40); // Buton 2'nin konumunu belirleyin
                button2.Size = new Size(75, 30); // Buton 2 boyutunu belirleyin
                companyPanel.Controls.Add(button2); // Buton 2'yi ekleyin

                Button button3 = new Button();
                button3.Text = "İşlem 3";
                button3.Location = new Point(170, 40); // Buton 3'ün konumunu belirleyin
                button3.Size = new Size(75, 30); // Buton 3 boyutunu belirleyin
                companyPanel.Controls.Add(button3); // Buton 3'ü ekleyin

                // Paneli form üzerine ekleyin
                this.Controls.Add(companyPanel);
            }


        }
    }
}
