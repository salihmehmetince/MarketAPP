using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class ProductUnitRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public ProductUnitRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblProductUnit> DALProductUnitList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblProductUnit.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occurred while listing the product Units", e);
            }
        }

        public int DALProductUnitAdd(TblProductUnit productUnit)
        {
            try
            {
                if(productUnit != null)
                {
                    dBMarketAppEntitiesContext.TblProductUnit.Add(productUnit);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return productUnit.productUnitId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occurred while adding the product Unit", e);
            }
        }


        public int DALProductUnitUpdate(TblProductUnit productUnit)
        {
            try
            {
                TblProductUnit existingProductUnit = dBMarketAppEntitiesContext.TblProductUnit.Find(productUnit.productUnitId);
                if(existingProductUnit!=null)
                {
                    existingProductUnit.productUnitName = productUnit.productUnitName;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingProductUnit.productUnitId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occurred while updating the product Unit", e);
            }
        }

        public int DALProductUnitDelete(TblProductUnit productUnit)
        {
            try
            {
                TblProductUnit existingProductUnit = dBMarketAppEntitiesContext.TblProductUnit.Find(productUnit.productUnitId);
                if (existingProductUnit != null)
                {
                    dBMarketAppEntitiesContext.TblProductUnit.Remove(existingProductUnit);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingProductUnit.productUnitId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occurred while updating the product Unit", e);
            }
        }
        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
