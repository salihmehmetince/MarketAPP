using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class TblWarehouseInventoryRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public TblWarehouseInventoryRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblWarehouseInventory> DALTblWarehouseInventoryList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblWarehouseInventory.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the TblWarehouseInventory", e);
            }
        }

        public int DALTblWarehouseInventoryAdd(TblWarehouseInventory warehouseInventory)
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

        public int DALTblWarehouseInventoryUpdate(TblWarehouseInventory warehouseInventory)
        {
            try
            {
                TblWarehouseInventory existingTblWarehouseInventory = dBMarketAppEntitiesContext.TblWarehouseInventory.Find(warehouseInventory.warehouseInventoryId);
                if (existingTblWarehouseInventory != null)
                {
                    existingTblWarehouseInventory.warehouseId = warehouseInventory.warehouseId;
                    existingTblWarehouseInventory.productTemplateId = warehouseInventory.productTemplateId;
                    existingTblWarehouseInventory.totalAmount = warehouseInventory.totalAmount;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingTblWarehouseInventory.warehouseInventoryId;
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

        public int DALTblWarehouseInventoryDelete(TblWarehouseInventory warehouseInventory)
        {
            try
            {
                TblWarehouseInventory existingTblWarehouseInventory = dBMarketAppEntitiesContext.TblWarehouseInventory.Find(warehouseInventory.warehouseInventoryId);
                if (existingTblWarehouseInventory != null)
                {
                    dBMarketAppEntitiesContext.TblWarehouseInventory.Remove(existingTblWarehouseInventory);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingTblWarehouseInventory.warehouseInventoryId;
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
