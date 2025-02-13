using MarketAppProject.EntityLayer;
using MarketAppProject.HelperFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class FactorySendsProductToMarketManager
    {
        public List<TblFactorySendsProductToMarket> BLFactorySendsProductToMarketList()
        {
            using (var repository = new FactorySendsProductToMarketRepository())
            {
                return repository.DALFactorySendsProductToMarketList();
            }
        }

        public int BLFactorySendsProductToMarketAdd(TblFactorySendsProductToMarket factorySendsProductToMarket)
        {
            if (factorySendsProductToMarket.factoryId<0
                ||factorySendsProductToMarket.marketId<0
                ||factorySendsProductToMarket.productTemplateId<0
                ||factorySendsProductToMarket.productQuantity<0
                ||FieldCheck.checkDateTimeField(factorySendsProductToMarket.senddate)
                ||factorySendsProductToMarket.sendVehicle<0
                )
            {
                return -1;
            }

            using (var repository = new FactorySendsProductToMarketRepository())
            {
                return repository.DALFactorySendsProductToMarketAdd(factorySendsProductToMarket);
            }
        }
        public int BLFactorySendsProductToMarketUpdate(TblFactorySendsProductToMarket factorySendsProductToMarket)
        {
            if (factorySendsProductToMarket.factorySendsProductToMarketId<0
                ||factorySendsProductToMarket.factoryId<0
                ||factorySendsProductToMarket.marketId<0
                ||factorySendsProductToMarket.productTemplateId<0
                ||factorySendsProductToMarket.productQuantity<0
                ||FieldCheck.checkDateTimeField(factorySendsProductToMarket.senddate)
                ||factorySendsProductToMarket.sendVehicle<0
                )
            {
                return -1;
            }

            using (var repository = new FactorySendsProductToMarketRepository())
            {
                return repository.DALFactorySendsProductToMarketUpdate(factorySendsProductToMarket);
            }
        }

        public int BLFactorySendsProductToMarketDelete(TblFactorySendsProductToMarket factorySendsProductToMarket)
        {
            using (var repository = new FactorySendsProductToMarketRepository())
            {
                return repository.DALFactorySendsProductToMarketDelete(factorySendsProductToMarket);
            }
        }
    }
}
