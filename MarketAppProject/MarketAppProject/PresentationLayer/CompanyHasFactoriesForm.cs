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
    public partial class CompanyHasFactoriesForm : Form
    {
        private TblCompany company;
        public CompanyHasFactoriesForm(TblCompany company)
        {
            InitializeComponent();
            this.company = company;
        }

        private void CompanyHasFactoriesForm_Load(object sender, EventArgs e)
        {
            CompanyHasFactoryManager companyHasFactoryManager = new CompanyHasFactoryManager();
            List<TblCompanyHasFactory> companyHasFactories = companyHasFactoryManager.BLCompanyHasFactoryList();
            FactoryManager factoryManager = new FactoryManager();
            List<TblFactory> factories = factoryManager.BLFactoryList();
            List<TblFactory> companyFactories =
                (from factory in factories
                 join companyHasFactory in companyHasFactories
                 on factory.factoryId equals companyHasFactory.factoryId
                 where companyHasFactory.companyId == company.companyId
                       && companyHasFactory.isActive == true
                 select factory).ToList();

            CreateFactoryGroupBoxes(companyFactories);
        }

        private void CreateFactoryGroupBoxes(List<TblFactory> factories)
        {
            this.Controls.OfType<GroupBox>().ToList().ForEach(gb => this.Controls.Remove(gb));

            int startX = 50;
            int startY = 100;
            int groupBoxWidth = 200;
            int groupBoxHeight = 100;
            int horizontalSpacing = 20; // Sütunlar arası boşluk
            int verticalSpacing = 20;   // Satırlar arası boşluk
            int columns = 5; // Kaç sütun olacağını belirliyoruz

            for (int i = 0; i < factories.Count; i++)
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
                Label lblFactoryName = new Label();
                lblFactoryName.Text = factories[index].factoryName;
                lblFactoryName.AutoSize = true;
                lblFactoryName.Location = new Point(10, 20);
                lblFactoryName.Font = new Font("Times New Roman", 10, FontStyle.Bold);

                // Button oluştur (İşlem Yap)
                Button btnTransaction = new Button();
                btnTransaction.Text = "Make Transaction";
                btnTransaction.Size = new Size(150, 30);
                btnTransaction.Location = new Point(10, 50);
                btnTransaction.BackColor = Color.LightBlue;
                btnTransaction.FlatStyle = FlatStyle.Flat;

                btnTransaction.Tag = factories[i]; // Butona şirket bilgisini ata

                btnTransaction.Click += (s, e) =>
                {
                    Button clickedButton = (Button)s;
                    TblFactory factory = (TblFactory)clickedButton.Tag; // Butondan şirketi al

                    CompanyHasFactoryManager companyHasFactoryManager = new CompanyHasFactoryManager();
                    TblCompanyHasFactory companyHasFactory = companyHasFactoryManager
                        .BLCompanyHasFactoryList()
                        .FirstOrDefault(c => c.companyId == company.companyId);

                    CompanyHasFactoryMakeTransactionForm companyHasFactoryMakeTransactionForm = new CompanyHasFactoryMakeTransactionForm(
                        factory, companyHasFactory);
                    companyHasFactoryMakeTransactionForm.ShowDialog();
                };

                // GroupBox içine bileşenleri ekle
                groupBox.Controls.Add(lblFactoryName);
                groupBox.Controls.Add(btnTransaction);

                // Form'a ekle
                this.Controls.Add(groupBox);
            }

        }


    }
}
