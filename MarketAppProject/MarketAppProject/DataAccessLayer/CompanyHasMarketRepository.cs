using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class CompanyHasMarketRepository:IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;
        
        public CompanyHasMarketRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblCompanyHasMarket> DALCompanyHasMarketList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblCompanyHasMarket.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the company has markets", e);
            }
        }

        public int DALCompanyHasMarketAdd(TblCompanyHasMarket companyHasMarket)
        {
            try
            {
                if(companyHasMarket != null)
                {
                    dBMarketAppEntitiesContext.TblCompanyHasMarket.Add(companyHasMarket);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return companyHasMarket.companyHasMarketId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the company has market", e);
            }
        }

        public int DALCompanyHasMarketUpdate(TblCompanyHasMarket companyHasMarket)
        {
            try
            {
                TblCompanyHasMarket existingCompanyHasMarket = dBMarketAppEntitiesContext.TblCompanyHasMarket.Find(companyHasMarket.companyHasMarketId);
                if(existingCompanyHasMarket != null)
                {
                    existingCompanyHasMarket.companyId = companyHasMarket.companyId;
                    existingCompanyHasMarket.marketId=companyHasMarket.marketId;
                    existingCompanyHasMarket.ownershipStartDate = companyHasMarket.ownershipStartDate;
                    existingCompanyHasMarket.ownershipEndDate = companyHasMarket.ownershipEndDate;
                    existingCompanyHasMarket.isActive = companyHasMarket.isActive;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingCompanyHasMarket.companyHasMarketId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the company has market", e);
            }
        }

        public int DALCompanyHasMarketDelete(TblCompanyHasMarket companyHasMarket)
        {
            try
            {
                TblCompanyHasMarket existingCompanyHasMarket = dBMarketAppEntitiesContext.TblCompanyHasMarket.Find(companyHasMarket.companyHasMarketId);
                if (existingCompanyHasMarket != null)
                {
                    dBMarketAppEntitiesContext.TblCompanyHasMarket.Remove(existingCompanyHasMarket);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingCompanyHasMarket.companyHasMarketId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the company has market", e);
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
