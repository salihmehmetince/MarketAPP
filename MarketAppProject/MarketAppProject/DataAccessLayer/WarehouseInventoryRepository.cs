using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class WarehouseInventoryRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public WarehouseInventoryRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblWarehouseInventory> DALWarehouseInventoryList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblWarehouseInventory.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the WarehouseInventory", e);
            }
        }

        public int DALWarehouseInventoryAdd(TblWarehouseInventory warehouseInventory)
        {
            try
            {
                if (warehouseInventory != null)
                {
                    dBMarketAppEntitiesContext.TblWarehouseInventory.Add(warehouseInventory);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return warehouseInventory.warehouseInventoryId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the warehouseInventory", e);
            }
        }

        public int DALWarehouseInventoryUpdate(TblWarehouseInventory warehouseInventory)
        {
            try
            {
                TblWarehouseInventory existingWarehouseInventory = dBMarketAppEntitiesContext.TblWarehouseInventory.Find(warehouseInventory.warehouseInventoryId);
                if (existingWarehouseInventory != null)
                {
                    existingWarehouseInventory.warehouseId = warehouseInventory.warehouseId;
                    existingWarehouseInventory.productTemplateId = warehouseInventory.productTemplateId;
                    existingWarehouseInventory.totalAmount = warehouseInventory.totalAmount;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingWarehouseInventory.warehouseInventoryId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the warehouseInventory", e);
            }
        }

        public int DALWarehouseInventoryDelete(TblWarehouseInventory warehouseInventory)
        {
            try
            {
                TblWarehouseInventory existingWarehouseInventory = dBMarketAppEntitiesContext.TblWarehouseInventory.Find(warehouseInventory.warehouseInventoryId);
                if (existingWarehouseInventory != null)
                {
                    dBMarketAppEntitiesContext.TblWarehouseInventory.Remove(existingWarehouseInventory);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingWarehouseInventory.warehouseInventoryId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the warehouseInventory", e);
            }
        }

        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
