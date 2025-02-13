using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class FactoryInventoryRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public FactoryInventoryRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblFactoryInventory> DALFactoryInventoryList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblFactoryInventory.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the FactoryInventory", e);
            }
        }

        public int DALFactoryInventoryAdd(TblFactoryInventory factoryInventory)
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

        public int DALFactoryInventoryUpdate(TblFactoryInventory factoryInventory)
        {
            try
            {
                TblFactoryInventory existingFactoryInventory = dBMarketAppEntitiesContext.TblFactoryInventory.Find(factoryInventory.factoryInventoryId);
                if (existingFactoryInventory != null)
                {
                    existingFactoryInventory.factoryId = factoryInventory.factoryId;
                    existingFactoryInventory.productTemplateId = factoryInventory.productTemplateId;
                    existingFactoryInventory.totalAmount = factoryInventory.totalAmount;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingFactoryInventory.factoryInventoryId;
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

        public int DALFactoryInventoryDelete(TblFactoryInventory factoryInventory)
        {
            try
            {
                TblFactoryInventory existingFactoryInventory = dBMarketAppEntitiesContext.TblFactoryInventory.Find(factoryInventory.factoryInventoryId);
                if (existingFactoryInventory != null)
                {
                    dBMarketAppEntitiesContext.TblFactoryInventory.Remove(existingFactoryInventory);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingFactoryInventory.factoryInventoryId;
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
