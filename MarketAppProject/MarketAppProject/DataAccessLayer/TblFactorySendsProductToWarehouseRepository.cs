using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class TblFactorySendsProductToWarehouseRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public TblFactorySendsProductToWarehouseRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblFactorySendsProductToWarehouse> DALTblFactorySendsProductToWarehouseList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblFactorySendsProductToWarehouse.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the TblFactorySendsProductToWarehouse", e);
            }
        }

        public int DALTblFactorySendsProductToWarehouseAdd(TblFactorySendsProductToWarehouse factorySendsProductToWarehouse)
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

        public int DALTblFactorySendsProductToWarehouseUpdate(TblFactorySendsProductToWarehouse factorySendsProductToWarehouse)
        {
            try
            {
                TblFactorySendsProductToWarehouse existingTblFactorySendsProductToWarehouse = dBMarketAppEntitiesContext.TblFactorySendsProductToWarehouse.Find(factorySendsProductToWarehouse.factorySendsProductToWarehouseId);
                if (existingTblFactorySendsProductToWarehouse != null)
                {
                    existingTblFactorySendsProductToWarehouse.factoryId = factorySendsProductToWarehouse.factoryId;
                    existingTblFactorySendsProductToWarehouse.warehouseId = factorySendsProductToWarehouse.warehouseId;
                    existingTblFactorySendsProductToWarehouse.productTemplateId = factorySendsProductToWarehouse.productTemplateId;
                    existingTblFactorySendsProductToWarehouse.productQuantity = factorySendsProductToWarehouse.productQuantity;
                    existingTblFactorySendsProductToWarehouse.sendDate = factorySendsProductToWarehouse.sendDate;
                    existingTblFactorySendsProductToWarehouse.sendVehicle = factorySendsProductToWarehouse.sendVehicle;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingTblFactorySendsProductToWarehouse.factorySendsProductToWarehouseId;
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

        public int DALTblFactorySendsProductToWarehouseDelete(TblFactorySendsProductToWarehouse factorySendsProductToWarehouse)
        {
            try
            {
                TblFactorySendsProductToWarehouse existingTblFactorySendsProductToWarehouse = dBMarketAppEntitiesContext.TblFactorySendsProductToWarehouse.Find(factorySendsProductToWarehouse.factorySendsProductToWarehouseId);
                if (existingTblFactorySendsProductToWarehouse != null)
                {
                    dBMarketAppEntitiesContext.TblFactorySendsProductToWarehouse.Remove(existingTblFactorySendsProductToWarehouse);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingTblFactorySendsProductToWarehouse.factorySendsProductToWarehouseId;
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
