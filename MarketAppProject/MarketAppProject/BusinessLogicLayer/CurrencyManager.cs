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
    internal class CurrencyManager
    {
        public List<TblCurrency> BLCurrencyList()
        {
            using (var repository = new CurrencyRepository())
            {
                return repository.DALCurrencyList();
            }
        }

        public int BLCurrencyAdd(TblCurrency currency)
        {
            if (currency.currencyNameCode.Length<2|| currency.currencyNameCode.Length>40)
            {
                return -1;
            }

            using (var repository = new CurrencyRepository())
            {
                return repository.DALCurrencyAdd(currency);
            }
        }
        public int BLCurrencyUpdate(TblCurrency currency)
        {
            if (currency.currencyId<0 ||currency.currencyNameCode.Length<2|| currency.currencyNameCode.Length>40)
            {
                return -1;
            }

            using (var repository = new CurrencyRepository())
            {
                return repository.DALCurrencyUpdate(currency);
            }
        }

        public int BLCurrencyDelete(TblCurrency currency)
        {
            if (currency.currencyId < 0)
            {
                return -1;
            }
            using (var repository = new CurrencyRepository())
            {
                return repository.DALCurrencyDelete(currency);
            }
        }
    }
}
