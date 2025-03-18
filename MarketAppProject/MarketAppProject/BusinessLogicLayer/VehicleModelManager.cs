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
    internal class VehicleModelManager
    {
        public List<TblVehicleModel> BLVehicleModelList()
        {
            using (var repository = new VehicleModelRepository())
            {
                return repository.DALVehicleModelList();
            }
        }

        public int BLVehicleModelAdd(TblVehicleModel vehicleModel)
        {
            if (!FieldCheck.checkBasicStringField(vehicleModel.vehicleModelName, 1, 40)
                )
            {
                return -1;
            }

            using (var repository = new VehicleModelRepository())
            {
                return repository.DALVehicleModelAdd(vehicleModel);
            }
        }
        public int BLVehicleModelUpdate(TblVehicleModel vehicleModel)
        {
            if (vehicleModel.vehicleModelId<0
                ||!FieldCheck.checkBasicStringField(vehicleModel.vehicleModelName, 1, 40)
                )
            {
                return -1;
            }

            using (var repository = new VehicleModelRepository())
            {
                return repository.DALVehicleModelUpdate(vehicleModel);
            }
        }

        public int BLVehicleModelDelete(TblVehicleModel vehicleModel)
        {
            if(vehicleModel.vehicleModelId < 0)
            {
                return -1;
            }
            using (var repository = new VehicleModelRepository())
            {
                return repository.DALVehicleModelDelete(vehicleModel);
            }
        }
    }
}
