using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class CountryRepository:IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public CountryRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblCountry> DALCountryList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblCountry.ToList();
            }
            catch(Exception e)
            {
                throw new Exception("An error occured while listing the countries", e);
            }
        }

        public int DALCountryAdd(TblCountry country)
        {
            try
            {
                if (country != null)
                {
                    dBMarketAppEntitiesContext.TblCountry.Add(country);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return country.countryId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the country", e);
            }
        }

        public int DALCountryUpdate(TblCountry country)
        {
            try
            {
                TblCountry existingCountry = dBMarketAppEntitiesContext.TblCountry.Find(country.countryId);
                if (existingCountry != null)
                {
                    existingCountry.countryName= country.countryName;
                    existingCountry.countryProductionCode= country.countryProductionCode;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingCountry.countryId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the country", e);
            }
        }

        public int DALCountryDelete(TblCountry country)
        {
            try
            {
                TblCountry existingCountry = dBMarketAppEntitiesContext.TblCountry.Find(country.countryId);
                if (existingCountry != null)
                {
                    dBMarketAppEntitiesContext.TblCountry.Remove(existingCountry);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingCountry.countryId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the country", e);
            }
        }

        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
