using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class CurrencyRepository:IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public CurrencyRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblCurrency> DALCurrencyList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblCurrency.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the currency", e);
            }
        }

        public int DALCurrencyAdd(TblCurrency currency)
        {
            try
            {
                if (currency != null)
                {
                    dBMarketAppEntitiesContext.TblCurrency.Add(currency);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return currency.currencyId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the currency", e);
            }
        }

        public int DALCurrencyUpdate(TblCurrency currency)
        {
            try
            {
                TblCurrency existingCurrency = dBMarketAppEntitiesContext.TblCurrency.Find(currency.currencyId);
                if (existingCurrency != null)
                {
                    existingCurrency.currencyNameCode = currency.currencyNameCode;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingCurrency.currencyId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the currency", e);
            }
        }

        public int DALCurrencyDelete(TblCurrency currency)
        {
            try
            {
                TblCurrency existingCurrency = dBMarketAppEntitiesContext.TblCurrency.Find(currency.currencyId);
                if (existingCurrency != null)
                {
                    dBMarketAppEntitiesContext.TblCurrency.Remove(existingCurrency);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingCurrency.currencyId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the currency", e);
            }
        }

        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
