using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class CompanyRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public CompanyRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblCompany> DALCompanyList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblCompany.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the companies", e);
            }
        }

        public int DALCompanyAdd(TblCompany company)
        {
            try
            {
                if (company != null)
                {
                    dBMarketAppEntitiesContext.TblCompany.Add(company);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return company.companyId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the company", e);
            }
        }

        public int DALCompanyUpdate(TblCompany company)
        {
            try
            {
                TblCompany existingCompany = dBMarketAppEntitiesContext.TblCompany.Find(company.companyId);

                if(existingCompany!=null)
                {
                    existingCompany.companyName = company.companyName;
                    existingCompany.companyType = company.companyType;
                    existingCompany.companyCountry = company.companyCountry;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingCompany.companyId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the company", e);
            }
        }

        public int DALCompanyDelete(TblCompany company)
        {
            try
            {
                TblCompany existingCompany = dBMarketAppEntitiesContext.TblCompany.Find(company.companyId);

                if (existingCompany != null)
                {
                    dBMarketAppEntitiesContext.TblCompany.Remove(existingCompany);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingCompany.companyId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the company", e);
            }
        }
        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
