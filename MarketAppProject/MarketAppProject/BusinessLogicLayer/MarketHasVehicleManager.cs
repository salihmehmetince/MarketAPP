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
    internal class MarketHasVehicleManager
    {
        public List<TblMarketHasVehicle> BLMarketHasVehicleList()
        {
            using (var repository = new MarketHasVehicleRepository())
            {
                return repository.DALMarketHasVehicleList();
            }
        }

        public int BLMarketHasVehicleAdd(TblMarketHasVehicle marketHasVehicle)
        {
            if (marketHasVehicle.marketId<0
                ||marketHasVehicle.vehicleId<0
                || marketHasVehicle.vehiclePurchaseMilAge < 0
                ||marketHasVehicle.vehiclePurchasePrice < 0
                ||FieldCheck.checkDateTimeField(marketHasVehicle.vehiclePurchaseDate)
                )
            {
                return -1;
            }

            using (var repository = new MarketHasVehicleRepository())
            {
                return repository.DALMarketHasVehicleAdd(marketHasVehicle);
            }
        }
        public int BLMarketHasVehicleUpdate(TblMarketHasVehicle marketHasVehicle)
        {
            if (marketHasVehicle.marketHasVehicleId<0
                ||marketHasVehicle.marketId<0
                ||marketHasVehicle.vehicleId<0
                || marketHasVehicle.vehiclePurchaseMilAge < 0
                ||marketHasVehicle.vehiclePurchasePrice < 0
                ||FieldCheck.checkDateTimeField(marketHasVehicle.vehiclePurchaseDate)
                )
            {
                return -1;
            }

            using (var repository = new MarketHasVehicleRepository())
            {
                return repository.DALMarketHasVehicleUpdate(marketHasVehicle);
            }
        }

        public int BLMarketHasVehicleDelete(TblMarketHasVehicle marketHasVehicle)
        {
            using (var repository = new MarketHasVehicleRepository())
            {
                return repository.DALMarketHasVehicleDelete(marketHasVehicle);
            }
        }
    }
}
