using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class CompanyOwnerHasCompanyRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public CompanyOwnerHasCompanyRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblCompanyOwerHasCompany> DALCompanyOwnerHasCompanyList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblCompanyOwerHasCompany.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the company owner has company", e);
            }
        }

        public int DALCompanyOwnerHasCompanyAdd(TblCompanyOwerHasCompany companyOwerHasCompany)
        {
            try
            {
                if(companyOwerHasCompany != null)
                {
                    dBMarketAppEntitiesContext.TblCompanyOwerHasCompany.Add(companyOwerHasCompany);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return companyOwerHasCompany.CompanyOwerHasCompanyId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the company owner has company", e);
            }
        }

        public int DALCompanyOwnerHasCompanyUpdate(TblCompanyOwerHasCompany companyOwerHasCompany)
        {
            try
            {
                TblCompanyOwerHasCompany existingCompanyOwnerhasCompany = dBMarketAppEntitiesContext.TblCompanyOwerHasCompany.Find(companyOwerHasCompany.CompanyOwerHasCompanyId);
                if (existingCompanyOwnerhasCompany != null)
                {
                    existingCompanyOwnerhasCompany.companyOwner = companyOwerHasCompany.companyOwner;
                    existingCompanyOwnerhasCompany.company = companyOwerHasCompany.company;
                    existingCompanyOwnerhasCompany.companyOwnerPercent= companyOwerHasCompany.companyOwnerPercent;
                    existingCompanyOwnerhasCompany.startDate= companyOwerHasCompany.startDate;
                    existingCompanyOwnerhasCompany.endDate= companyOwerHasCompany.endDate;
                    existingCompanyOwnerhasCompany.isActive= companyOwerHasCompany.isActive;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingCompanyOwnerhasCompany.CompanyOwerHasCompanyId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the company owner has company", e);
            }
        }

        public int DALCompanyOwnerHasCompanyDelete(TblCompanyOwerHasCompany companyOwerHasCompany)
        {
            try
            {
                TblCompanyOwerHasCompany existingCompanyOwnerhasCompany = dBMarketAppEntitiesContext.TblCompanyOwerHasCompany.Find(companyOwerHasCompany.CompanyOwerHasCompanyId);
                if (existingCompanyOwnerhasCompany != null)
                {
                    dBMarketAppEntitiesContext.TblCompanyOwerHasCompany.Remove(existingCompanyOwnerhasCompany);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingCompanyOwnerhasCompany.CompanyOwerHasCompanyId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the company owner has company", e);
            }
        }

        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
