using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class WarehouseSendsToMarketRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public WarehouseSendsToMarketRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblWarehouseSendsToMarket> DALWarehouseSendsToMarketList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblWarehouseSendsToMarket.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the WarehouseSendsToMarket", e);
            }
        }

        public int DALWarehouseSendsToMarketAdd(TblWarehouseSendsToMarket warehouseSendsToMarket)
        {
            try
            {
                if (warehouseSendsToMarket != null)
                {
                    dBMarketAppEntitiesContext.TblWarehouseSendsToMarket.Add(warehouseSendsToMarket);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return warehouseSendsToMarket.warehouseSendsToMarketId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the warehouseSendsToMarket", e);
            }
        }

        public int DALWarehouseSendsToMarketUpdate(TblWarehouseSendsToMarket warehouseSendsToMarket)
        {
            try
            {
                TblWarehouseSendsToMarket existingWarehouseSendsToMarket = dBMarketAppEntitiesContext.TblWarehouseSendsToMarket.Find(warehouseSendsToMarket.warehouseSendsToMarketId);
                if (existingWarehouseSendsToMarket != null)
                {
                    existingWarehouseSendsToMarket.warehouseId = warehouseSendsToMarket.warehouseId;
                    existingWarehouseSendsToMarket.marketId = warehouseSendsToMarket.marketId;
                    existingWarehouseSendsToMarket.productTemplateId = warehouseSendsToMarket.productTemplateId;
                    existingWarehouseSendsToMarket.productQuantity = warehouseSendsToMarket.productQuantity;
                    existingWarehouseSendsToMarket.sendDate = warehouseSendsToMarket.sendDate;
                    existingWarehouseSendsToMarket.sendVehicle = warehouseSendsToMarket.sendVehicle;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingWarehouseSendsToMarket.warehouseSendsToMarketId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the warehouseSendsToMarket", e);
            }
        }

        public int DALWarehouseSendsToMarketDelete(TblWarehouseSendsToMarket warehouseSendsToMarket)
        {
            try
            {
                TblWarehouseSendsToMarket existingWarehouseSendsToMarket = dBMarketAppEntitiesContext.TblWarehouseSendsToMarket.Find(warehouseSendsToMarket.warehouseSendsToMarketId);
                if (existingWarehouseSendsToMarket != null)
                {
                    dBMarketAppEntitiesContext.TblWarehouseSendsToMarket.Remove(existingWarehouseSendsToMarket);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingWarehouseSendsToMarket.warehouseSendsToMarketId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the warehouseSendsToMarket", e);
            }
        }

        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
