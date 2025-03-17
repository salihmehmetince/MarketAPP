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
    internal class VehicleManager
    {
        public List<TblVehicle> BLVehicleList()
        {
            using (var repository = new VehicleRepository())
            {
                return repository.DALVehicleList();
            }
        }

        public int BLVehicleAdd(TblVehicle vehicle)
        {
            if (FieldCheck.checkBasicStringField(vehicle.vehicleSerialNumber, 1, 20)
                ||vehicle.vehicleType<0
                ||vehicle.vehicleBrand<0
                ||vehicle.vehicleModel<0
                )
            {
                return -1;
            }

            using (var repository = new VehicleRepository())
            {
                return repository.DALVehicleAdd(vehicle);
            }
        }
        public int BLVehicleUpdate(TblVehicle vehicle)
        {
            if (vehicle.vehicleId<0
                ||FieldCheck.checkBasicStringField(vehicle.vehicleSerialNumber, 1, 20)
                ||vehicle.vehicleType<0
                ||vehicle.vehicleBrand<0
                ||vehicle.vehicleModel<0
                )
            {
                return -1;
            }

            using (var repository = new VehicleRepository())
            {
                return repository.DALVehicleUpdate(vehicle);
            }
        }

        public int BLVehicleDelete(TblVehicle vehicle)
        {
            if(vehicle.vehicleId< 0)
            {
                return -1;
            }
            using (var repository = new VehicleRepository())
            {
                return repository.DALVehicleDelete(vehicle);
            }
        }
    }
}
