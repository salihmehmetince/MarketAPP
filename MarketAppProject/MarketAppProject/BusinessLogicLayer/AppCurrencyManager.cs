using MarketAppProject.DataAccessLayer;
using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.BusinessLogicLayer
{
    internal class AppCurrencyManager
    {
        public List<TblAppCurrency> BLAppCurrencyList()
        {
            using (var repository = new AppCurrencyRepository())
            {
                return repository.DALAppCurrencyList();
            }
        }

        public int BLAppCurrencyAdd(TblAppCurrency appCurrency)
        {
            if (string.IsNullOrWhiteSpace(appCurrency.appCurrencyCode) || appCurrency.appCurrencyCode.Length!=3)
            {
                return -1;
            }

            using (var repository = new AppCurrencyRepository())
            {
                return repository.DALAppCurrencyAdd(appCurrency);
            }
        }

        public int BLAppCurrencyUpdate(TblAppCurrency appCurrency)
        {
            using (var repository = new AppCurrencyRepository())
            {
                if (appCurrency.appCurrencyId<0 
                    ||string.IsNullOrWhiteSpace(appCurrency.appCurrencyCode) 
                    || appCurrency.appCurrencyCode.Length != 3)
                {
                    return -1;
                }
                else
                {
                    return repository.DALAppCurrencyUpdate(appCurrency);
                }
            }
        }

        public int BLAppCurrencyDelete(TblAppCurrency appCurrency)
        {
            if (appCurrency.appCurrencyId < 0)
            {
                return -1;
            }
            using (var repository = new AppCurrencyRepository())
            {
                return repository.DALAppCurrencyDelete(appCurrency);
            }
        }
    }
}
