using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class TblFactoryProductProductionRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public TblFactoryProductProductionRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblFactoryProductProduction> DALTblFactoryProductProductionList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblFactoryProductProduction.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the TblFactoryProductProduction", e);
            }
        }


        public int DALTblFactoryProductProductionAdd(TblFactoryProductProduction factoryProductProduction)
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


        public int DALTblFactoryProductProductionUpdate(TblFactoryProductProduction factoryProductProduction)
        {
            try
            {
                TblFactoryProductProduction existingTblFactoryProductProduction = dBMarketAppEntitiesContext.TblFactoryProductProduction.Find(factoryProductProduction.factoryProductProductionId);
                if (existingTblFactoryProductProduction != null)
                {
                    existingTblFactoryProductProduction.factoryId = factoryProductProduction.factoryId;
                    existingTblFactoryProductProduction.productTemplateId = factoryProductProduction.productTemplateId;
                    existingTblFactoryProductProduction.productQuantity = factoryProductProduction.productQuantity;
                    existingTblFactoryProductProduction.productionDate = factoryProductProduction.productionDate;
                    existingTblFactoryProductProduction.expirationDate = factoryProductProduction.expirationDate;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingTblFactoryProductProduction.factoryProductProductionId;
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

        public int DALTblFactoryProductProductionDelete(TblFactoryProductProduction factoryProductProduction)
        {
            try
            {
                TblFactoryProductProduction existingTblFactoryProductProduction = dBMarketAppEntitiesContext.TblFactoryProductProduction.Find(factoryProductProduction.factoryProductProductionId);
                if (existingTblFactoryProductProduction != null)
                {
                    dBMarketAppEntitiesContext.TblFactoryProductProduction.Remove(existingTblFactoryProductProduction);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingTblFactoryProductProduction.factoryProductProductionId;
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
