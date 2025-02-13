using MarketAppProject.DataAccessLayer;
using MarketAppProject.EntityLayer;
using MarketAppProject.HelperFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.BusinessLogicLayer
{
    internal class FactorySendsProductToWarehouseManager
    {
        public List<TblFactorySendsProductToWarehouse> BLFactorySendsProductToWarehouseList()
        {
            using (var repository = new FactorySendsProductToWarehouseRepository())
            {
                return repository.DALFactorySendsProductToWarehouseList();
            }
        }

        public int BLFactorySendsProductToWarehouseAdd(TblFactorySendsProductToWarehouse factorySendsProductToWarehouse)
        {
            if (factorySendsProductToWarehouse.factoryId<0
                ||factorySendsProductToWarehouse.warehouseId < 0
                ||factorySendsProductToWarehouse.productTemplateId < 0
                ||factorySendsProductToWarehouse.productQuantity < 0
                ||FieldCheck.checkDateTimeField(factorySendsProductToWarehouse.sendDate)
                ||factorySendsProductToWarehouse.sendVehicle<0
                )
            {
                return -1;
            }

            using (var repository = new FactorySendsProductToWarehouseRepository())
            {
                return repository.DALFactorySendsProductToWarehouseAdd(factorySendsProductToWarehouse);
            }
        }
        public int BLFactorySendsProductToWarehouseUpdate(TblFactorySendsProductToWarehouse factorySendsProductToWarehouse)
        {
            if (factorySendsProductToWarehouse.factorySendsProductToWarehouseId < 0
                ||factorySendsProductToWarehouse.factoryId<0
                ||factorySendsProductToWarehouse.warehouseId < 0
                ||factorySendsProductToWarehouse.productTemplateId < 0
                ||factorySendsProductToWarehouse.productQuantity < 0
                ||FieldCheck.checkDateTimeField(factorySendsProductToWarehouse.sendDate)
                ||factorySendsProductToWarehouse.sendVehicle<0
                )
            {
                return -1;
            }

            using (var repository = new FactorySendsProductToWarehouseRepository())
            {
                return repository.DALFactorySendsProductToWarehouseUpdate(factorySendsProductToWarehouse);
            }
        }

        public int BLFactorySendsProductToWarehouseDelete(TblFactorySendsProductToWarehouse factorySendsProductToWarehouse)
        {
            using (var repository = new FactorySendsProductToWarehouseRepository())
            {
                return repository.DALFactorySendsProductToWarehouseDelete(factorySendsProductToWarehouse);
            }
        }
    }
}
