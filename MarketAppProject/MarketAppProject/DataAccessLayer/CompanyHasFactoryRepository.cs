using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class CompanyHasFactoryRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public CompanyHasFactoryRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblCompanyHasFactory> DALCompanyHasFactoryList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblCompanyHasFactory.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the company has factories", e);
            }
        }

        public int DALCompanyHasFactoryAdd(TblCompanyHasFactory companyHasFactory)
        {
            try
            {
                if(companyHasFactory != null)
                {
                    dBMarketAppEntitiesContext.TblCompanyHasFactory.Add(companyHasFactory);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return companyHasFactory.companyHasFactoryId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the company has factory", e);
            }
        }

        public int DALCompanyHasFactoryUpdate(TblCompanyHasFactory companyHasFactory)
        {
            try
            {
                TblCompanyHasFactory existingCompanyHasFactory = dBMarketAppEntitiesContext.TblCompanyHasFactory.Find(companyHasFactory.companyHasFactoryId);
                if(existingCompanyHasFactory != null)
                {
                    existingCompanyHasFactory.companyId= companyHasFactory.companyId;
                    existingCompanyHasFactory.factoryId= companyHasFactory.factoryId;
                    existingCompanyHasFactory.ownershipStartDate= companyHasFactory.ownershipStartDate;
                    existingCompanyHasFactory.ownershipEndDate= companyHasFactory.ownershipEndDate;
                    existingCompanyHasFactory.isActive= companyHasFactory.isActive;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingCompanyHasFactory.companyHasFactoryId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the company has factory", e);
            }
        }

        public int DALCompanyHasFactoryDelete(TblCompanyHasFactory companyHasFactory)
        {
            try
            {
                TblCompanyHasFactory existingCompanyHasFactory = dBMarketAppEntitiesContext.TblCompanyHasFactory.Find(companyHasFactory.companyHasFactoryId);
                if (existingCompanyHasFactory != null)
                {
                    dBMarketAppEntitiesContext.TblCompanyHasFactory.Remove(existingCompanyHasFactory);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingCompanyHasFactory.companyHasFactoryId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the company has factory", e);
            }
        }
        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
