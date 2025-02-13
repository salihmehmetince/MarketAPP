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
    internal class FactoryHasVehicleManager
    {
        public List<TblFactoryHasVehicle> BLFactoryHasVehicleList()
        {
            using (var repository = new FactoryHasVehicleRepository())
            {
                return repository.DALFactoryHasVehicleList();
            }
        }

        public int BLFactoryHasVehicleAdd(TblFactoryHasVehicle factoryHasVehicle)
        {
            if (factoryHasVehicle.factoryId<0
                || factoryHasVehicle.vehicleId<0
                || factoryHasVehicle.vehiclePurchaseMilAge<0
                || factoryHasVehicle.vehiclePurchasePrice<0
                || FieldCheck.checkDateTimeField(factoryHasVehicle.vehiclePurchaseDate)
                )
            {
                return -1;
            }

            using (var repository = new FactoryHasVehicleRepository())
            {
                return repository.DALFactoryHasVehicleAdd(factoryHasVehicle);
            }
        }
        public int BLFactoryHasVehicleUpdate(TblFactoryHasVehicle factoryHasVehicle)
        {
            if (factoryHasVehicle.factoryHasVehicleId<0
                ||factoryHasVehicle.factoryId<0
                || factoryHasVehicle.vehicleId<0
                || factoryHasVehicle.vehiclePurchaseMilAge<0
                || factoryHasVehicle.vehiclePurchasePrice<0
                || FieldCheck.checkDateTimeField(factoryHasVehicle.vehiclePurchaseDate)
                )
            {
                return -1;
            }

            using (var repository = new FactoryHasVehicleRepository())
            {
                return repository.DALFactoryHasVehicleUpdate(factoryHasVehicle);
            }
        }

        public int BLFactoryHasVehicleDelete(TblFactoryHasVehicle factoryHasVehicle)
        {
            using (var repository = new FactoryHasVehicleRepository())
            {
                return repository.DALFactoryHasVehicleDelete(factoryHasVehicle);
            }
        }
    }
}
