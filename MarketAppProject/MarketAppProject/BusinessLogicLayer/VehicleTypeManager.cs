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
    internal class VehicleTypeManager
    {
        public List<TblVehicleType> BLVehicleTypeList()
        {
            using (var repository = new VehicleTypeRepository())
            {
                return repository.DALVehicleTypeList();
            }
        }

        public int BLVehicleTypeAdd(TblVehicleType vehicleType)
        {
            if (FieldCheck.checkBasicStringField(vehicleType.vehicleTypeName, 1, 40)
                )
            {
                return -1;
            }

            using (var repository = new VehicleTypeRepository())
            {
                return repository.DALVehicleTypeAdd(vehicleType);
            }
        }
        public int BLVehicleTypeUpdate(TblVehicleType vehicleType)
        {
            if (vehicleType.vehicleTypeId<0
                ||FieldCheck.checkBasicStringField(vehicleType.vehicleTypeName, 1, 40)
                )
            {
                return -1;
            }

            using (var repository = new VehicleTypeRepository())
            {
                return repository.DALVehicleTypeUpdate(vehicleType);
            }
        }

        public int BLVehicleTypeDelete(TblVehicleType vehicleType)
        {
            if(vehicleType.vehicleTypeId<0)
            {
                return -1;
            }
            using (var repository = new VehicleTypeRepository())
            {
                return repository.DALVehicleTypeDelete(vehicleType);
            }
        }
    }
}
