using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class ProductTypeRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public ProductTypeRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblProductType> DALProductTypeList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblProductType.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the product types", e);
            }
        }

        public int DALProductTypeAdd(TblProductType productType)
        {
            try
            {
                if (productType != null)
                {
                    dBMarketAppEntitiesContext.TblProductType.Add(productType);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return productType.productTypeId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the product type", e);
            }
        }

        public int DALProductTypeUpdate(TblProductType productType)
        {
            try
            {
                TblProductType existingProductType = dBMarketAppEntitiesContext.TblProductType.Find(productType.productTypeId);
                if(existingProductType!=null)
                {
                    existingProductType.productTypeName=productType.productTypeName;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingProductType.productTypeId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the product type", e);
            }
        }

        public int DALProductTypeDelete(TblProductType productType)
        {
            try
            {
                TblProductType existingProductType = dBMarketAppEntitiesContext.TblProductType.Find(productType.productTypeId);
                if (existingProductType != null)
                {
                    dBMarketAppEntitiesContext.TblProductType.Remove(existingProductType);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingProductType.productTypeId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the product type", e);
            }
        }
        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
