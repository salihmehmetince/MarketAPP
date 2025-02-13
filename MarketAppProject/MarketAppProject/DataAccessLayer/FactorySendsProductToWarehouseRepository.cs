using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class FactorySendsProductToWarehouseRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public FactorySendsProductToWarehouseRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblFactorySendsProductToWarehouse> DALFactorySendsProductToWarehouseList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblFactorySendsProductToWarehouse.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the FactorySendsProductToWarehouse", e);
            }
        }

        public int DALFactorySendsProductToWarehouseAdd(TblFactorySendsProductToWarehouse factorySendsProductToWarehouse)
        {
            try
            {
                if (factorySendsProductToWarehouse != null)
                {
                    dBMarketAppEntitiesContext.TblFactorySendsProductToWarehouse.Add(factorySendsProductToWarehouse);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return factorySendsProductToWarehouse.factorySendsProductToWarehouseId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the factorySendsProductToWarehouse", e);
            }
        }

        public int DALFactorySendsProductToWarehouseUpdate(TblFactorySendsProductToWarehouse factorySendsProductToWarehouse)
        {
            try
            {
                TblFactorySendsProductToWarehouse existingFactorySendsProductToWarehouse = dBMarketAppEntitiesContext.TblFactorySendsProductToWarehouse.Find(factorySendsProductToWarehouse.factorySendsProductToWarehouseId);
                if (existingFactorySendsProductToWarehouse != null)
                {
                    existingFactorySendsProductToWarehouse.factoryId = factorySendsProductToWarehouse.factoryId;
                    existingFactorySendsProductToWarehouse.warehouseId = factorySendsProductToWarehouse.warehouseId;
                    existingFactorySendsProductToWarehouse.productTemplateId = factorySendsProductToWarehouse.productTemplateId;
                    existingFactorySendsProductToWarehouse.productQuantity = factorySendsProductToWarehouse.productQuantity;
                    existingFactorySendsProductToWarehouse.sendDate = factorySendsProductToWarehouse.sendDate;
                    existingFactorySendsProductToWarehouse.sendVehicle = factorySendsProductToWarehouse.sendVehicle;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingFactorySendsProductToWarehouse.factorySendsProductToWarehouseId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the factorySendsProductToWarehouse", e);
            }
        }

        public int DALFactorySendsProductToWarehouseDelete(TblFactorySendsProductToWarehouse factorySendsProductToWarehouse)
        {
            try
            {
                TblFactorySendsProductToWarehouse existingFactorySendsProductToWarehouse = dBMarketAppEntitiesContext.TblFactorySendsProductToWarehouse.Find(factorySendsProductToWarehouse.factorySendsProductToWarehouseId);
                if (existingFactorySendsProductToWarehouse != null)
                {
                    dBMarketAppEntitiesContext.TblFactorySendsProductToWarehouse.Remove(existingFactorySendsProductToWarehouse);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingFactorySendsProductToWarehouse.factorySendsProductToWarehouseId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the factorySendsProductToWarehouse", e);
            }
        }

        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
