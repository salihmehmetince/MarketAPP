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
    internal class CountryManager
    {
        public List<TblCountry> BLCountryList()
        {
            using (var repository = new CountryRepository())
            {
                return repository.DALCountryList();
            }
        }

        public int BLCountryAdd(TblCountry country)
        {
            if (string.IsNullOrWhiteSpace(country.countryName)
                ||country.countryName.Length<1
                ||country.countryName.Length>40
                || string.IsNullOrWhiteSpace(country.countryProductionCode)
                || country.countryProductionCode.Length!=3
                )
            {
                return -1;
            }

            using (var repository = new CountryRepository())
            {
                return repository.DALCountryAdd(country);
            }
        }
        public int BLCountryUpdate(TblCountry country)
        {
            if (country.countryId<0
                ||string.IsNullOrWhiteSpace(country.countryName)
                ||country.countryName.Length<1
                ||country.countryName.Length>40
                || string.IsNullOrWhiteSpace(country.countryProductionCode)
                || country.countryProductionCode.Length!=3
                )
            {
                return -1;
            }

            using (var repository = new CountryRepository())
            {
                return repository.DALCountryUpdate(country);
            }
        }

        public int BLCountryDelete(TblCountry country)
        {
            using (var repository = new CountryRepository())
            {
                return repository.DALCountryDelete(country);
            }
        }
    }
}
