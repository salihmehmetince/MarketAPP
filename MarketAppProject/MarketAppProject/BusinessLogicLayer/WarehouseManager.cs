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
    internal class WarehouseManager
    {

        public List<TblWarehouse> BLWarehouseList()
        {
            using (var repository = new WarehouseRepository())
            {
                return repository.DALWarehouseList();
            }
        }

        public int BLWarehouseAdd(TblWarehouse warehouse)
        {
            if (!FieldCheck.checkBasicStringField(warehouse.warehouseName, 1, 40)
                || !FieldCheck.checkAddressField(warehouse.warehouseAddress)
                || !FieldCheck.checkPhoneField(warehouse.warehouseTelephoneNumber)
                || !FieldCheck.checkEmailField(warehouse.warehouseEmail)
                )
            {
                return -1;
            }

            using (var repository = new WarehouseRepository())
            {
                return repository.DALWarehouseAdd(warehouse);
            }
        }
        public int BLWarehouseUpdate(TblWarehouse warehouse)
        {
            if (warehouse.warehouseId<0
                ||!FieldCheck.checkBasicStringField(warehouse.warehouseName, 1, 40)
                || !FieldCheck.checkAddressField(warehouse.warehouseAddress)
                || !FieldCheck.checkPhoneField(warehouse.warehouseTelephoneNumber)
                || !FieldCheck.checkEmailField(warehouse.warehouseEmail)
                )
            {
                return -1;
            }

            using (var repository = new WarehouseRepository())
            {
                return repository.DALWarehouseUpdate(warehouse);
            }
        }
        public int BLWarehouseDelete(TblWarehouse warehouse)
        {
            if (warehouse.warehouseId<0)
            {
                return -1;
            }

            using (var repository = new WarehouseRepository())
            {
                return repository.DALWarehouseDelete(warehouse);
            }
        }
    }
}
