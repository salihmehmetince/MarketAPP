using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class CompanyHasWarehouseRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public CompanyHasWarehouseRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();    
        }

        public List<TblCompanyHasWarehouse> DALCompanyHasWarehouseList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblCompanyHasWarehouse.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the company has warehouses", e);
            }
        }

        public int DALCompanyHasWarehouseAdd(TblCompanyHasWarehouse companyHasWarehouse)
        {
            try
            {
                if(companyHasWarehouse != null)
                {
                    dBMarketAppEntitiesContext.TblCompanyHasWarehouse.Add(companyHasWarehouse);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return companyHasWarehouse.companyHasWarehouseId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the company has warehouse", e);
            }
        }

        public int DALCompanyHasWarehouseUpdate(TblCompanyHasWarehouse companyHasWarehouse)
        {
            try
            {
                TblCompanyHasWarehouse existingCompanyHasWarehouse = dBMarketAppEntitiesContext.TblCompanyHasWarehouse.Find(companyHasWarehouse.companyHasWarehouseId);
                if(existingCompanyHasWarehouse != null)
                {
                    existingCompanyHasWarehouse.companyId = companyHasWarehouse.companyId;
                    existingCompanyHasWarehouse.warehouseId = companyHasWarehouse.warehouseId;
                    existingCompanyHasWarehouse.ownershipStartDate=companyHasWarehouse.ownershipStartDate;
                    existingCompanyHasWarehouse.ownershipEndDate=companyHasWarehouse.ownershipEndDate;
                    existingCompanyHasWarehouse.isActive=companyHasWarehouse.isActive;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingCompanyHasWarehouse.companyHasWarehouseId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the company has warehouse", e);
            }
        }

        public int DALCompanyHasWarehouseDelete(TblCompanyHasWarehouse companyHasWarehouse)
        {
            try
            {
                TblCompanyHasWarehouse existingCompanyHasWarehouse = dBMarketAppEntitiesContext.TblCompanyHasWarehouse.Find(companyHasWarehouse.companyHasWarehouseId);
                if (existingCompanyHasWarehouse != null)
                {
                    dBMarketAppEntitiesContext.TblCompanyHasWarehouse.Remove(existingCompanyHasWarehouse);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingCompanyHasWarehouse.companyHasWarehouseId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the company has warehouse", e);
            }
        }

        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
