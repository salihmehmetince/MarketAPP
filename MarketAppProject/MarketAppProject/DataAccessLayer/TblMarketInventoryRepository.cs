using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class TblMarketInventoryRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public TblMarketInventoryRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblMarketInventory> DALTblMarketInventoryList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblMarketInventory.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the TblMarketInventory", e);
            }
        }

        public int DALTblMarketInventoryAdd(TblMarketInventory marketInventory)
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

        public int DALTblMarketInventoryUpdate(TblMarketInventory marketInventory)
        {
            try
            {
                TblMarketInventory existingTblMarketInventory = dBMarketAppEntitiesContext.TblMarketInventory.Find(marketInventory.marketInventoryId);
                if (existingTblMarketInventory != null)
                {
                    existingTblMarketInventory.marketId = marketInventory.marketInventoryId;
                    existingTblMarketInventory.productTemplateId = marketInventory.productTemplateId;
                    existingTblMarketInventory.totalAmount = marketInventory.totalAmount;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingTblMarketInventory.marketInventoryId;
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

        public int DALTblMarketInventoryDelete(TblMarketInventory marketInventory)
        {
            try
            {
                TblMarketInventory existingTblMarketInventory = dBMarketAppEntitiesContext.TblMarketInventory.Find(marketInventory.marketInventoryId);
                if (existingTblMarketInventory != null)
                {
                    dBMarketAppEntitiesContext.TblMarketInventory.Remove(existingTblMarketInventory);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingTblMarketInventory.marketInventoryId;
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
