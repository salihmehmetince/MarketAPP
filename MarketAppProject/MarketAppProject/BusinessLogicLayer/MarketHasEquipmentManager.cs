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
    internal class MarketHasEquipmentManager
    {
        public List<TblMarketHasEquipment> BLMarketHasEquipmentList()
        {
            using (var repository = new MarketHasEquipmentRepository())
            {
                return repository.DALMarketHasEquipmentList();
            }
        }

        public int BLMarketHasEquipmentAdd(TblMarketHasEquipment marketHasEquipment)
        {
            if (marketHasEquipment.marketId<0
                ||marketHasEquipment.equipmentId<0
                ||FieldCheck.checkDateTimeField(marketHasEquipment.purchaseDate)
                ||marketHasEquipment.purchasePrice < 0
                )
            {
                return -1;
            }

            using (var repository = new MarketHasEquipmentRepository())
            {
                return repository.DALMarketHasEquipmentAdd(marketHasEquipment);
            }
        }
        public int BLMarketHasEquipmentUpdate(TblMarketHasEquipment marketHasEquipment)
        {
            if (marketHasEquipment.marketHasEquipmentId<0
                ||marketHasEquipment.marketId<0
                ||marketHasEquipment.equipmentId<0
                ||FieldCheck.checkDateTimeField(marketHasEquipment.purchaseDate)
                ||marketHasEquipment.purchasePrice < 0
                )
            {
                return -1;
            }

            using (var repository = new MarketHasEquipmentRepository())
            {
                return repository.DALMarketHasEquipmentUpdate(marketHasEquipment);
            }
        }

        public int BLMarketHasEquipmentDelete(TblMarketHasEquipment marketHasEquipment)
        {
            using (var repository = new MarketHasEquipmentRepository())
            {
                return repository.DALMarketHasEquipmentDelete(marketHasEquipment);
            }
        }
    }
}
