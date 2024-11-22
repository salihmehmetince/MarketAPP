using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class ProductKindRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public ProductKindRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblProductKind> DALProductKindList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblProductKind.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occurred while listing the product kinds", e);
            }
        }

        public int DALProductKindAdd(TblProductKind productKind)
        {
            try
            {
                if(productKind != null)
                {
                    dBMarketAppEntitiesContext.TblProductKind.Add(productKind);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return productKind.productKindId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occurred while adding the product kind", e);
            }
        }

        public int DALProductKindUpdate(TblProductKind productKind)
        {
            try
            {
                TblProductKind existingProductKind = dBMarketAppEntitiesContext.TblProductKind.Find(productKind.productKindId);
                if(existingProductKind != null)
                {
                    existingProductKind.productKindName = productKind.productKindName;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingProductKind.productKindId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occurred while updating the product kind", e);
            }
        }

        public int DALProductKindDelete(TblProductKind productKind)
        {
            try
            {
                TblProductKind existingProductKind = dBMarketAppEntitiesContext.TblProductKind.Find(productKind.productKindId);
                if (existingProductKind != null)
                {
                    dBMarketAppEntitiesContext.TblProductKind.Remove(existingProductKind);  
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingProductKind.productKindId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occurred while deleting the product kind", e);
            }
        }
        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
