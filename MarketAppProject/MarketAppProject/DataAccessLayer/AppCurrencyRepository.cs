using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class AppCurrencyRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public AppCurrencyRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblAppCurrency> DALAppCurrencyList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblAppCurrency.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the AppCurrency", e);
            }
        }

        public int DALAppCurrencyAdd(TblAppCurrency appCurrency)
        {
            try
            {
                if (appCurrency != null)
                {
                    dBMarketAppEntitiesContext.TblAppCurrency.Add(appCurrency);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return appCurrency.appCurrencyId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the appCurrency", e);
            }
        }

        public int DALAppCurrencyUpdate(TblAppCurrency appCurrency)
        {
            try
            {
                TblAppCurrency existingAppCurrency = dBMarketAppEntitiesContext.TblAppCurrency.Find(appCurrency.appCurrencyId);
                if (existingAppCurrency != null)
                {
                    existingAppCurrency.appCurrencyCode = appCurrency.appCurrencyCode;
                    existingAppCurrency.isActive = appCurrency.isActive;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingAppCurrency.appCurrencyId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the appCurrency", e);
            }
        }

        public int DALAppCurrencyDelete(TblAppCurrency appCurrency)
        {
            try
            {
                TblAppCurrency existingAppCurrency = dBMarketAppEntitiesContext.TblAppCurrency.Find(appCurrency.appCurrencyId);
                if (existingAppCurrency != null)
                {
                    dBMarketAppEntitiesContext.TblAppCurrency.Remove(existingAppCurrency);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingAppCurrency.appCurrencyId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the appCurrency", e);
            }
        }

        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
