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
    internal class WarehouseSendsToMarketManager
    {
        public List<TblWarehouseSendsToMarket> BLWarehouseSendsToMarketList()
        {
            using (var repository = new WarehouseSendsToMarketRepository())
            {
                return repository.DALWarehouseSendsToMarketList();
            }
        }

        public int BLWarehouseSendsToMarketAdd(TblWarehouseSendsToMarket warehouseSendsToMarket)
        {
            if (warehouseSendsToMarket.warehouseId<0
                ||warehouseSendsToMarket.marketId<0
                ||warehouseSendsToMarket.productTemplateId<0
                ||warehouseSendsToMarket.productQuantity<0
                ||!FieldCheck.checkDateTimeField(warehouseSendsToMarket.sendDate)
                ||warehouseSendsToMarket.sendVehicle<0
                )
            {
                return -1;
            }

            using (var repository = new WarehouseSendsToMarketRepository())
            {
                return repository.DALWarehouseSendsToMarketAdd(warehouseSendsToMarket);
            }
        }

        public int BLWarehouseSendsToMarketUpdate(TblWarehouseSendsToMarket warehouseSendsToMarket)
        {
            if (warehouseSendsToMarket.warehouseSendsToMarketId<0
                ||warehouseSendsToMarket.warehouseId<0
                ||warehouseSendsToMarket.marketId<0
                ||warehouseSendsToMarket.productTemplateId<0
                ||warehouseSendsToMarket.productQuantity<0
                ||!FieldCheck.checkDateTimeField(warehouseSendsToMarket.sendDate)
                ||warehouseSendsToMarket.sendVehicle<0
                )
            {
                return -1;
            }

            using (var repository = new WarehouseSendsToMarketRepository())
            {
                return repository.DALWarehouseSendsToMarketUpdate(warehouseSendsToMarket);
            }
        }

        public int BLWarehouseSendsToMarketDelete(TblWarehouseSendsToMarket warehouseSendsToMarket)
        {
            if(warehouseSendsToMarket.warehouseSendsToMarketId<0)
            {
                return -1;
            }
            using (var repository = new WarehouseSendsToMarketRepository())
            {
                return repository.DALWarehouseSendsToMarketDelete(warehouseSendsToMarket);
            }
        }
    }
}
