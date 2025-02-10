using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class TblWarehouseSendsToMarketRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public TblWarehouseSendsToMarketRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblWarehouseSendsToMarket> DALTblWarehouseSendsToMarketList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblWarehouseSendsToMarket.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the TblWarehouseSendsToMarket", e);
            }
        }

        public int DALTblWarehouseSendsToMarketAdd(TblWarehouseSendsToMarket warehouseSendsToMarket)
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

        public int DALTblWarehouseSendsToMarketUpdate(TblWarehouseSendsToMarket warehouseSendsToMarket)
        {
            try
            {
                TblWarehouseSendsToMarket existingTblWarehouseSendsToMarket = dBMarketAppEntitiesContext.TblWarehouseSendsToMarket.Find(warehouseSendsToMarket.warehouseSendsToMarketId);
                if (existingTblWarehouseSendsToMarket != null)
                {
                    existingTblWarehouseSendsToMarket.warehouseId = warehouseSendsToMarket.warehouseId;
                    existingTblWarehouseSendsToMarket.marketId = warehouseSendsToMarket.marketId;
                    existingTblWarehouseSendsToMarket.productTemplateId = warehouseSendsToMarket.productTemplateId;
                    existingTblWarehouseSendsToMarket.productQuantity = warehouseSendsToMarket.productQuantity;
                    existingTblWarehouseSendsToMarket.sendDate = warehouseSendsToMarket.sendDate;
                    existingTblWarehouseSendsToMarket.sendVehicle = warehouseSendsToMarket.sendVehicle;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingTblWarehouseSendsToMarket.warehouseSendsToMarketId;
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

        public int DALTblWarehouseSendsToMarketDelete(TblWarehouseSendsToMarket warehouseSendsToMarket)
        {
            try
            {
                TblWarehouseSendsToMarket existingTblWarehouseSendsToMarket = dBMarketAppEntitiesContext.TblWarehouseSendsToMarket.Find(warehouseSendsToMarket.warehouseSendsToMarketId);
                if (existingTblWarehouseSendsToMarket != null)
                {
                    dBMarketAppEntitiesContext.TblWarehouseSendsToMarket.Remove(existingTblWarehouseSendsToMarket);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingTblWarehouseSendsToMarket.warehouseSendsToMarketId;
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
