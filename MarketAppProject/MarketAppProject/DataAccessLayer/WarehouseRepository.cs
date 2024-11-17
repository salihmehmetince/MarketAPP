using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class WarehouseRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public WarehouseRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblWarehouse> DALWarehouseList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblWarehouse.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the warehouses", e);
            }
        }

        public int DALWarehouseAdd(TblWarehouse warehouse)
        {
            try
            {
                if(warehouse != null)
                {
                    dBMarketAppEntitiesContext.TblWarehouse.Add(warehouse);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return warehouse.warehouseId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the warehouse", e);
            }
        }

        public int DALWarehouseUpdate(TblWarehouse warehouse)
        {
            try
            {
                TblWarehouse existingWarehouse = dBMarketAppEntitiesContext.TblWarehouse.Find(warehouse.warehouseId);
                if(existingWarehouse != null)
                {
                    existingWarehouse.warehouseName = warehouse.warehouseName;
                    existingWarehouse.warehouseAddress = warehouse.warehouseAddress;
                    existingWarehouse.warehouseEmail = warehouse.warehouseEmail;
                    existingWarehouse.warehouseTelephoneNumber= warehouse.warehouseTelephoneNumber;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingWarehouse.warehouseId;   
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the warehouse", e);
            }
        }

        public int DALWarehouseDelete(TblWarehouse warehouse)
        {
            try
            {
                TblWarehouse existingWarehouse = dBMarketAppEntitiesContext.TblWarehouse.Find(warehouse.warehouseId);
                if (existingWarehouse != null)
                {
                    dBMarketAppEntitiesContext.TblWarehouse.Remove(existingWarehouse);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingWarehouse.warehouseId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the warehouse", e);
            }
        }

        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
