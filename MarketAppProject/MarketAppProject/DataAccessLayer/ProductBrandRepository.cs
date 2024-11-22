using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class ProductBrandRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public ProductBrandRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblProductBrand> DALProductBrandList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblProductBrand.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occurred while listing the product brands", e);
            }
        }

        public int DALProductBrandAdd(TblProductBrand productBrand)
        {
            try
            {
                if(productBrand != null)
                {
                    dBMarketAppEntitiesContext.TblProductBrand.Add(productBrand);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return productBrand.productBrandId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occurred while adding the product brand", e);
            }
        }

        public int DALProductBrandUpdate(TblProductBrand productBrand)
        {
            try
            {
                TblProductBrand existingProductBrand = dBMarketAppEntitiesContext.TblProductBrand.Find(productBrand.productBrandId);
                if(existingProductBrand != null)
                {
                    existingProductBrand.productBrandName=productBrand.productBrandName;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingProductBrand.productBrandId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occurred while updating the product brand", e);
            }
        }

        public int DALProductBrandDelete(TblProductBrand productBrand)
        {
            try
            {
                TblProductBrand existingProductBrand = dBMarketAppEntitiesContext.TblProductBrand.Find(productBrand.productBrandId);
                if (existingProductBrand != null)
                {
                    dBMarketAppEntitiesContext.TblProductBrand.Remove(existingProductBrand);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingProductBrand.productBrandId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occurred while deleting the product brand", e);
            }
        }

        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
