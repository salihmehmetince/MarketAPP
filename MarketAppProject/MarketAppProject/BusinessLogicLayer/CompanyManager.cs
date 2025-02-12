using MarketAppProject.DataAccessLayer;
using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.BusinessLogicLayer
{
    internal class CompanyManager
    {
        public List<TblCompany> BLCompanyList()
        {
            using (var repository = new CompanyRepository())
            {
                return repository.DALCompanyList();
            }
        }

        public int BLCompanyAdd(TblCompany company)
        {
            if (string.IsNullOrWhiteSpace(company.companyName) || company.companyName.Length<2 || company.companyName.Length>30 || company.companyType<1 || company.companyCountry<1)
            {
                return -1;
            }

            using (var repository = new CompanyRepository())
            {
                return repository.DALCompanyAdd(company);
            }
        }

        public int BLCompanyUpdate(TblCompany company)
        {
            if (company.companyId<0
                ||string.IsNullOrWhiteSpace(company.companyName) 
                || company.companyName.Length < 2 
                || company.companyName.Length > 30 
                || company.companyType < 1 
                || company.companyCountry < 1)
            {
                return -1;
            }

            using (var repository = new CompanyRepository())
            {
                return repository.DALCompanyUpdate(company);
            }
        }

        public int BLCompanyDelete(TblCompany company)
        {
            using (var repository = new CompanyRepository())
            {
                return repository.DALCompanyDelete(company);
            }
        }
    }
}
