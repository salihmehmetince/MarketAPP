using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class MarketRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public MarketRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblMarket> DALMarketList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblMarket.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the markets", e);
            }
        }

        public int DALMarketAdd(TblMarket market)
        {
            try
            {
                if(market != null)
                {
                    dBMarketAppEntitiesContext.TblMarket.Add(market);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return market.marketId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the market", e);
            }
        }

        public int DALMarketUpdate(TblMarket market)
        {
            try
            {
                TblMarket existingMarket = dBMarketAppEntitiesContext.TblMarket.Find(market.marketId);
                if(existingMarket!=null)
                {
                    existingMarket.marketName= market.marketName;
                    existingMarket.marketAddress= market.marketAddress;
                    existingMarket.marketTelephoneNumber=market.marketTelephoneNumber;
                    existingMarket.marketEmail=market.marketEmail;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingMarket.marketId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the market", e);
            }
        }

        public int DALMarketDelete(TblMarket market)
        {
            try
            {
                TblMarket existingMarket = dBMarketAppEntitiesContext.TblMarket.Find(market.marketId);
                if (existingMarket != null)
                {
                    dBMarketAppEntitiesContext.TblMarket.Remove(existingMarket);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingMarket.marketId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the market", e);
            }
        }


        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
