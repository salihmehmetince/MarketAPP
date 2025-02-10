using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class TblFactorySendsProductToMarketRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public TblFactorySendsProductToMarketRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblFactorySendsProductToMarket> DALTblFactorySendsProductToMarketList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblFactorySendsProductToMarket.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the TblFactorySendsProductToMarket", e);
            }
        }

        public int DALTblFactorySendsProductToMarketAdd(TblFactorySendsProductToMarket factorySendsProductToMarket)
        {
            try
            {
                if (factorySendsProductToMarket != null)
                {
                    dBMarketAppEntitiesContext.TblFactorySendsProductToMarket.Add(factorySendsProductToMarket);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return factorySendsProductToMarket.factorySendsProductToMarketId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the factorySendsProductToMarket", e);
            }
        }

        public int DALTblFactorySendsProductToMarketUpdate(TblFactorySendsProductToMarket factorySendsProductToMarket)
        {
            try
            {
                TblFactorySendsProductToMarket existingTblFactorySendsProductToMarket = dBMarketAppEntitiesContext.TblFactorySendsProductToMarket.Find(factorySendsProductToMarket.factorySendsProductToMarketId);
                if (existingTblFactorySendsProductToMarket != null)
                {
                    existingTblFactorySendsProductToMarket.factoryId = factorySendsProductToMarket.factoryId;
                    existingTblFactorySendsProductToMarket.marketId = factorySendsProductToMarket.marketId;
                    existingTblFactorySendsProductToMarket.productTemplateId = factorySendsProductToMarket.productTemplateId;
                    existingTblFactorySendsProductToMarket.productQuantity = factorySendsProductToMarket.productQuantity;
                    existingTblFactorySendsProductToMarket.senddate = factorySendsProductToMarket.senddate;
                    existingTblFactorySendsProductToMarket.sendVehicle = factorySendsProductToMarket.sendVehicle;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingTblFactorySendsProductToMarket.factorySendsProductToMarketId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the factorySendsProductToMarket", e);
            }
        }

        public int DALTblFactorySendsProductToMarketDelete(TblFactorySendsProductToMarket factorySendsProductToMarket)
        {
            try
            {
                TblFactorySendsProductToMarket existingTblFactorySendsProductToMarket = dBMarketAppEntitiesContext.TblFactorySendsProductToMarket.Find(factorySendsProductToMarket.factorySendsProductToMarketId);
                if (existingTblFactorySendsProductToMarket != null)
                {
                    dBMarketAppEntitiesContext.TblFactorySendsProductToMarket.Remove(existingTblFactorySendsProductToMarket);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingTblFactorySendsProductToMarket.factorySendsProductToMarketId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the factorySendsProductToMarket", e);
            }
        }

        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
