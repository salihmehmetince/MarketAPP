using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class CompanyTypeRepository:IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public CompanyTypeRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblCompanyType> DALCompanyTypeList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblCompanyType.ToList();
            }
            catch(Exception e)
            {
                throw new Exception("An error occured while listing the company types", e);
            }
        }

        public int DALCompanyTypeAdd(TblCompanyType companyType)
        {
            try
            {
                if(companyType != null)
                {
                    dBMarketAppEntitiesContext.TblCompanyType.Add(companyType);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return companyType.companyTypeId;
                }
                else
                {
                    return -1;
                }
            }
            catch(Exception e)
            {
                throw new Exception("An error occured while adding the company type", e);
            }
        }

        public int DALCompanyTypeUpdate(TblCompanyType companyType)
        {
            try
            {
                TblCompanyType existingCompanyType = dBMarketAppEntitiesContext.TblCompanyType.Find(companyType.companyTypeId);
                if(existingCompanyType != null)
                {
                    existingCompanyType.companyTypeName= companyType.companyTypeName;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingCompanyType.companyTypeId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the company type", e);
            }
        }

        public int DALCompanyTypeDelete(TblCompanyType companyType)
        {
            try
            {
                TblCompanyType existingCompanyType = dBMarketAppEntitiesContext.TblCompanyType.Find(companyType.companyTypeId);
                if (existingCompanyType != null)
                {
                    dBMarketAppEntitiesContext.TblCompanyType.Remove(existingCompanyType);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingCompanyType.companyTypeId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the company type", e);
            }
        }
        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
