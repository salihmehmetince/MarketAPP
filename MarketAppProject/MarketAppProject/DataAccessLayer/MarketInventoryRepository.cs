using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class MarketInventoryRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public MarketInventoryRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblMarketInventory> DALMarketInventoryList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblMarketInventory.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the MarketInventory", e);
            }
        }

        public int DALMarketInventoryAdd(TblMarketInventory marketInventory)
        {
            try
            {
                if (marketInventory != null)
                {
                    dBMarketAppEntitiesContext.TblMarketInventory.Add(marketInventory);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return marketInventory.marketInventoryId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the marketInventory", e);
            }
        }

        public int DALMarketInventoryUpdate(TblMarketInventory marketInventory)
        {
            try
            {
                TblMarketInventory existingMarketInventory = dBMarketAppEntitiesContext.TblMarketInventory.Find(marketInventory.marketInventoryId);
                if (existingMarketInventory != null)
                {
                    existingMarketInventory.marketId = marketInventory.marketInventoryId;
                    existingMarketInventory.productTemplateId = marketInventory.productTemplateId;
                    existingMarketInventory.totalAmount = marketInventory.totalAmount;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingMarketInventory.marketInventoryId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the marketInventory", e);
            }
        }

        public int DALMarketInventoryDelete(TblMarketInventory marketInventory)
        {
            try
            {
                TblMarketInventory existingMarketInventory = dBMarketAppEntitiesContext.TblMarketInventory.Find(marketInventory.marketInventoryId);
                if (existingMarketInventory != null)
                {
                    dBMarketAppEntitiesContext.TblMarketInventory.Remove(existingMarketInventory);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingMarketInventory.marketInventoryId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the marketInventory", e);
            }
        }

        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
