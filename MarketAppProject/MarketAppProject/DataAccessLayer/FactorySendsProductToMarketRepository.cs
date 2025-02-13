using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class FactorySendsProductToMarketRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public FactorySendsProductToMarketRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblFactorySendsProductToMarket> DALFactorySendsProductToMarketList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblFactorySendsProductToMarket.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the FactorySendsProductToMarket", e);
            }
        }

        public int DALFactorySendsProductToMarketAdd(TblFactorySendsProductToMarket factorySendsProductToMarket)
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

        public int DALFactorySendsProductToMarketUpdate(TblFactorySendsProductToMarket factorySendsProductToMarket)
        {
            try
            {
                TblFactorySendsProductToMarket existingFactorySendsProductToMarket = dBMarketAppEntitiesContext.TblFactorySendsProductToMarket.Find(factorySendsProductToMarket.factorySendsProductToMarketId);
                if (existingFactorySendsProductToMarket != null)
                {
                    existingFactorySendsProductToMarket.factoryId = factorySendsProductToMarket.factoryId;
                    existingFactorySendsProductToMarket.marketId = factorySendsProductToMarket.marketId;
                    existingFactorySendsProductToMarket.productTemplateId = factorySendsProductToMarket.productTemplateId;
                    existingFactorySendsProductToMarket.productQuantity = factorySendsProductToMarket.productQuantity;
                    existingFactorySendsProductToMarket.senddate = factorySendsProductToMarket.senddate;
                    existingFactorySendsProductToMarket.sendVehicle = factorySendsProductToMarket.sendVehicle;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingFactorySendsProductToMarket.factorySendsProductToMarketId;
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

        public int DALFactorySendsProductToMarketDelete(TblFactorySendsProductToMarket factorySendsProductToMarket)
        {
            try
            {
                TblFactorySendsProductToMarket existingFactorySendsProductToMarket = dBMarketAppEntitiesContext.TblFactorySendsProductToMarket.Find(factorySendsProductToMarket.factorySendsProductToMarketId);
                if (existingFactorySendsProductToMarket != null)
                {
                    dBMarketAppEntitiesContext.TblFactorySendsProductToMarket.Remove(existingFactorySendsProductToMarket);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingFactorySendsProductToMarket.factorySendsProductToMarketId;
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
