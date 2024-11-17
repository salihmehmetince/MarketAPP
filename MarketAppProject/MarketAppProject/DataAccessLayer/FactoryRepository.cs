using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class FactoryRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public FactoryRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblFactory> DALFactoryList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblFactory.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the factories", e);
            }
        }

        public int DALFactoryAdd(TblFactory factory)
        {
            try
            {
                if(factory != null)
                {
                    dBMarketAppEntitiesContext.TblFactory.Add(factory);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return factory.factoryId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the factory", e);
            }
        }

        public int DALFactoryUpdate(TblFactory factory)
        {
            try
            {
                TblFactory existingFactory = dBMarketAppEntitiesContext.TblFactory.Find(factory.factoryId); 
                if(existingFactory!=null)
                {
                    existingFactory.factoryName = factory.factoryName;
                    existingFactory.factoryAddress = factory.factoryAddress;
                    existingFactory.factoryTelephoneNumber = factory.factoryTelephoneNumber;
                    existingFactory.factoryEmail = factory.factoryEmail;
                    existingFactory.factoryProductionCode = factory.factoryProductionCode;
                    existingFactory.factoryCountry=factory.factoryCountry;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingFactory.factoryId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the factory", e);
            }
        }

        public int DALFactoryDelete(TblFactory factory)
        {
            try
            {
                TblFactory existingFactory = dBMarketAppEntitiesContext.TblFactory.Find(factory.factoryId);
                if (existingFactory != null)
                {
                    dBMarketAppEntitiesContext.TblFactory.Remove(existingFactory);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingFactory.factoryId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the factory", e);
            }
        }


        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
