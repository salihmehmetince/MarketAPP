using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class FactoryProductProductionRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public FactoryProductProductionRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblFactoryProductProduction> DALFactoryProductProductionList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblFactoryProductProduction.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the FactoryProductProduction", e);
            }
        }


        public int DALFactoryProductProductionAdd(TblFactoryProductProduction factoryProductProduction)
        {
            try
            {
                if (factoryProductProduction != null)
                {
                    dBMarketAppEntitiesContext.TblFactoryProductProduction.Add(factoryProductProduction);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return factoryProductProduction.factoryProductProductionId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the factoryProductProduction", e);
            }
        }


        public int DALFactoryProductProductionUpdate(TblFactoryProductProduction factoryProductProduction)
        {
            try
            {
                TblFactoryProductProduction existingFactoryProductProduction = dBMarketAppEntitiesContext.TblFactoryProductProduction.Find(factoryProductProduction.factoryProductProductionId);
                if (existingFactoryProductProduction != null)
                {
                    existingFactoryProductProduction.factoryId = factoryProductProduction.factoryId;
                    existingFactoryProductProduction.productTemplateId = factoryProductProduction.productTemplateId;
                    existingFactoryProductProduction.productQuantity = factoryProductProduction.productQuantity;
                    existingFactoryProductProduction.productionDate = factoryProductProduction.productionDate;
                    existingFactoryProductProduction.expirationDate = factoryProductProduction.expirationDate;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingFactoryProductProduction.factoryProductProductionId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the factoryProductProduction", e);
            }
        }

        public int DALFactoryProductProductionDelete(TblFactoryProductProduction factoryProductProduction)
        {
            try
            {
                TblFactoryProductProduction existingFactoryProductProduction = dBMarketAppEntitiesContext.TblFactoryProductProduction.Find(factoryProductProduction.factoryProductProductionId);
                if (existingFactoryProductProduction != null)
                {
                    dBMarketAppEntitiesContext.TblFactoryProductProduction.Remove(existingFactoryProductProduction);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingFactoryProductProduction.factoryProductProductionId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the factoryProductProduction", e);
            }
        }

        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
