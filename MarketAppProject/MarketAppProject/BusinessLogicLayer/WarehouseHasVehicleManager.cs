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
    internal class WarehouseHasVehicleManager
    {
        public List<TblWarehouseHasVehicle> BLWarehouseHasVehicleList()
        {
            using (var repository = new WarehouseHasVehicleRepository())
            {
                return repository.DALWarehouseHasVehicleList();
            }
        }

        public int BLWarehouseHasVehicleAdd(TblWarehouseHasVehicle warehouseHasVehicle)
        {
            if (warehouseHasVehicle.warehouseId<0
                ||warehouseHasVehicle.vehicleId<0
                ||warehouseHasVehicle.vehiclePurchaseMilAge<0
                ||warehouseHasVehicle.vehiclePurchasePrice<0
                ||FieldCheck.checkDateTimeField(warehouseHasVehicle.vehiclePurchaseDate)
                )
            {
                return -1;
            }

            using (var repository = new WarehouseHasVehicleRepository())
            {
                return repository.DALWarehouseHasVehicleAdd(warehouseHasVehicle);
            }
        }
        public int BLWarehouseHasVehicleUpdate(TblWarehouseHasVehicle warehouseHasVehicle)
        {
            if (warehouseHasVehicle.warehouseHasVehicleId<0
                ||warehouseHasVehicle.warehouseId<0
                ||warehouseHasVehicle.vehicleId<0
                ||warehouseHasVehicle.vehiclePurchaseMilAge<0
                ||warehouseHasVehicle.vehiclePurchasePrice<0
                ||FieldCheck.checkDateTimeField(warehouseHasVehicle.vehiclePurchaseDate)
                )
            {
                return -1;
            }

            using (var repository = new WarehouseHasVehicleRepository())
            {
                return repository.DALWarehouseHasVehicleUpdate(warehouseHasVehicle);
            }
        }
        public int BLWarehouseHasVehicleDelete(TblWarehouseHasVehicle warehouseHasVehicle)
        {

            using (var repository = new WarehouseHasVehicleRepository())
            {
                return repository.DALWarehouseHasVehicleDelete(warehouseHasVehicle);
            }
        }
    }
}
