using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class TblFactoryProducedProductRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public TblFactoryProducedProductRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblFactoryProducedProduct> DALTblFactoryProducedProductList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblFactoryProducedProduct.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the TblFactoryProducedProduct", e);
            }
        }

        public int DALTblFactoryProducedProductAdd(TblFactoryProducedProduct factoryProducedProduct)
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

        public int DALTblFactoryProducedProductUpdate(TblFactoryProducedProduct factoryProducedProduct)
        {
            try
            {
                TblFactoryProducedProduct existingTblFactoryProducedProduct = dBMarketAppEntitiesContext.TblFactoryProducedProduct.Find(factoryProducedProduct.factoryProducedProductId);
                if (existingTblFactoryProducedProduct != null)
                {
                    existingTblFactoryProducedProduct.factoryId= factoryProducedProduct.factoryId;
                    existingTblFactoryProducedProduct.productTemplateId = factoryProducedProduct.productTemplateId;
                    existingTblFactoryProducedProduct.productiınDate = factoryProducedProduct.productiınDate;
                    existingTblFactoryProducedProduct.barkod = factoryProducedProduct.barkod;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingTblFactoryProducedProduct.factoryProducedProductId;
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

        public int DALTblFactoryProducedProductDelete(TblFactoryProducedProduct factoryProducedProduct)
        {
            try
            {
                TblFactoryProducedProduct existingTblFactoryProducedProduct = dBMarketAppEntitiesContext.TblFactoryProducedProduct.Find(factoryProducedProduct.factoryProducedProductId);
                if (existingTblFactoryProducedProduct != null)
                {
                    dBMarketAppEntitiesContext.TblFactoryProducedProduct.Remove(existingTblFactoryProducedProduct);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingTblFactoryProducedProduct.factoryProducedProductId;
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
