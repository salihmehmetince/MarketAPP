using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class WarehouseHasVehicleRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public WarehouseHasVehicleRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblWarehouseHasVehicle> DALWarehouseHasVehicleList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblWarehouseHasVehicle.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the warehouse has vehicles", e);
            }
        }

        public int DALWarehouseHasVehicleAdd(TblWarehouseHasVehicle warehouseHasVehicle)
        {
            try
            {
                if(warehouseHasVehicle!=null)
                {
                    dBMarketAppEntitiesContext.TblWarehouseHasVehicle.Add(warehouseHasVehicle);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return warehouseHasVehicle.warehouseHasVehicleId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the warehouse has vehicle", e);
            }
        }

        public int DALWarehouseHasVehicleUpdate(TblWarehouseHasVehicle warehouseHasVehicle)
        {
            try
            {
                TblWarehouseHasVehicle existingWarehouseHasVehicle = dBMarketAppEntitiesContext.TblWarehouseHasVehicle.Find(warehouseHasVehicle.warehouseHasVehicleId);
                if(existingWarehouseHasVehicle!=null)
                {
                    existingWarehouseHasVehicle.warehouseId = warehouseHasVehicle.warehouseId;
                    existingWarehouseHasVehicle.vehicleId = warehouseHasVehicle.vehicleId;
                    existingWarehouseHasVehicle.vehiclePurchaseMilAge = warehouseHasVehicle.vehiclePurchaseMilAge;
                    existingWarehouseHasVehicle.vehiclePurchasePrice = warehouseHasVehicle.vehiclePurchasePrice;
                    existingWarehouseHasVehicle.vehiclePurchaseDate = warehouseHasVehicle.vehiclePurchaseDate;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingWarehouseHasVehicle.warehouseHasVehicleId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the warehouse has vehicle", e);
            }
        }

        public int DALWarehouseHasVehicleDelete(TblWarehouseHasVehicle warehouseHasVehicle)
        {
            try
            {
                TblWarehouseHasVehicle existingWarehouseHasVehicle = dBMarketAppEntitiesContext.TblWarehouseHasVehicle.Find(warehouseHasVehicle.warehouseHasVehicleId);
                if (existingWarehouseHasVehicle != null)
                {
                    dBMarketAppEntitiesContext.TblWarehouseHasVehicle.Remove(existingWarehouseHasVehicle);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingWarehouseHasVehicle.warehouseHasVehicleId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the warehouse has vehicle", e);
            }
        }

        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
