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
    internal class MarketManager
    {
        public List<TblMarket> BLMarketList()
        {
            using (var repository = new MarketRepository())
            {
                return repository.DALMarketList();
            }
        }

        public int BLMarketAdd(TblMarket market)
        {
            if (!FieldCheck.checkBasicStringField(market.marketName, 1, 40)
                || !FieldCheck.checkAddressField(market.marketAddress)
                || !FieldCheck.checkPhoneField(market.marketTelephoneNumber)
                || !FieldCheck.checkEmailField(market.marketEmail)
                )
            {
                return -1;
            }

            using (var repository = new MarketRepository())
            {
                return repository.DALMarketAdd(market);
            }
        }
        public int BLMarketUpdate(TblMarket market)
        {
            if (market.marketId<0
                ||!FieldCheck.checkBasicStringField(market.marketName, 1, 40)
                || !FieldCheck.checkAddressField(market.marketAddress)
                || !FieldCheck.checkPhoneField(market.marketTelephoneNumber)
                || !FieldCheck.checkEmailField(market.marketEmail)
                )
            {
                return -1;
            }

            using (var repository = new MarketRepository())
            {
                return repository.DALMarketUpdate(market);
            }
        }
        public int BLMarketDelete(TblMarket market)
        {
            if(market.marketId<0)
            {
                return -1;
            }
            using (var repository = new MarketRepository())
            {
                return repository.DALMarketDelete(market);
            }
        }
    }
}
