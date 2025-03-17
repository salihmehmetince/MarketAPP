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
    internal class VehicleBrandManager
    {
        public List<TblVehicleBrand> BLVehicleBrandList()
        {
            using (var repository = new VehicleBrandRepository())
            {
                return repository.DALVehicleBrandList();
            }
        }

        public int BLVehicleBrandAdd(TblVehicleBrand vehicleBrand)
        {
            if (FieldCheck.checkBasicStringField(vehicleBrand.vehicleBrandName, 1, 40)
                )
            {
                return -1;
            }

            using (var repository = new VehicleBrandRepository())
            {
                return repository.DALVehicleBrandAdd(vehicleBrand);
            }
        }
        public int BLVehicleBrandUpdate(TblVehicleBrand vehicleBrand)
        {
            if (vehicleBrand.vehicleBrandId<0
                ||FieldCheck.checkBasicStringField(vehicleBrand.vehicleBrandName, 1, 40)
                )
            {
                return -1;
            }

            using (var repository = new VehicleBrandRepository())
            {
                return repository.DALVehicleBrandUpdate(vehicleBrand);
            }
        }

        public int BLVehicleBrandDelete(TblVehicleBrand vehicleBrand)
        {
            if(vehicleBrand.vehicleBrandId<0)
            {
                return -1;
            }
            using (var repository = new VehicleBrandRepository())
            {
                return repository.DALVehicleBrandDelete(vehicleBrand);
            }
        }
    }
}
