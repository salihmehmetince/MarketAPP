using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class TblFactoryInventoryRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public TblFactoryInventoryRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblFactoryInventory> DALTblFactoryInventoryList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblFactoryInventory.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the TblFactoryInventory", e);
            }
        }

        public int DALTblFactoryInventoryAdd(TblFactoryInventory factoryInventory)
        {
            try
            {
                if (factoryInventory != null)
                {
                    dBMarketAppEntitiesContext.TblFactoryInventory.Add(factoryInventory);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return factoryInventory.factoryInventoryId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the factory inventory", e);
            }
        }

        public int DALTblFactoryInventoryUpdate(TblFactoryInventory factoryInventory)
        {
            try
            {
                TblFactoryInventory existingTblFactoryInventory = dBMarketAppEntitiesContext.TblFactoryInventory.Find(factoryInventory.factoryInventoryId);
                if (existingTblFactoryInventory != null)
                {
                    existingTblFactoryInventory.factoryId = factoryInventory.factoryId;
                    existingTblFactoryInventory.productTemplateId = factoryInventory.productTemplateId;
                    existingTblFactoryInventory.totalAmount = factoryInventory.totalAmount;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingTblFactoryInventory.factoryInventoryId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the FactoryInventory", e);
            }
        }

        public int DALTblFactoryInventoryDelete(TblFactoryInventory factoryInventory)
        {
            try
            {
                TblFactoryInventory existingTblFactoryInventory = dBMarketAppEntitiesContext.TblFactoryInventory.Find(factoryInventory.factoryInventoryId);
                if (existingTblFactoryInventory != null)
                {
                    dBMarketAppEntitiesContext.TblFactoryInventory.Remove(existingTblFactoryInventory);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingTblFactoryInventory.factoryInventoryId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the factoryInventory", e);
            }
        }

        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
