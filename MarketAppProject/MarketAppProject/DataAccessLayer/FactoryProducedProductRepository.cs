using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class FactoryProducedProductRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public FactoryProducedProductRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblFactoryProducedProduct> DALFactoryProducedProductList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblFactoryProducedProduct.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the FactoryProducedProduct", e);
            }
        }

        public int DALFactoryProducedProductAdd(TblFactoryProducedProduct factoryProducedProduct)
        {
            try
            {
                if (factoryProducedProduct != null)
                {
                    dBMarketAppEntitiesContext.TblFactoryProducedProduct.Add(factoryProducedProduct);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return factoryProducedProduct.factoryProducedProductId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the factory produced product", e);
            }
        }

        public int DALFactoryProducedProductUpdate(TblFactoryProducedProduct factoryProducedProduct)
        {
            try
            {
                TblFactoryProducedProduct existingFactoryProducedProduct = dBMarketAppEntitiesContext.TblFactoryProducedProduct.Find(factoryProducedProduct.factoryProducedProductId);
                if (existingFactoryProducedProduct != null)
                {
                    existingFactoryProducedProduct.factoryId= factoryProducedProduct.factoryId;
                    existingFactoryProducedProduct.productTemplateId = factoryProducedProduct.productTemplateId;
                    existingFactoryProducedProduct.productiınDate = factoryProducedProduct.productiınDate;
                    existingFactoryProducedProduct.barkod = factoryProducedProduct.barkod;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingFactoryProducedProduct.factoryProducedProductId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the factoryProducedProduct", e);
            }
        }

        public int DALFactoryProducedProductDelete(TblFactoryProducedProduct factoryProducedProduct)
        {
            try
            {
                TblFactoryProducedProduct existingFactoryProducedProduct = dBMarketAppEntitiesContext.TblFactoryProducedProduct.Find(factoryProducedProduct.factoryProducedProductId);
                if (existingFactoryProducedProduct != null)
                {
                    dBMarketAppEntitiesContext.TblFactoryProducedProduct.Remove(existingFactoryProducedProduct);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingFactoryProducedProduct.factoryProducedProductId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the factoryProducedProduct", e);
            }
        }

        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
