using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class DepartmentTypeRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public DepartmentTypeRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblDepartmentType> DALDepartmentTypeList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblDepartmentType.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the department types", e);
            }
        }

        public int DALDepartmentTypeAdd(TblDepartmentType departmentType)
        {
            try
            {
                if(departmentType != null)
                {
                    dBMarketAppEntitiesContext.TblDepartmentType.Add(departmentType);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return departmentType.departmentTypeId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the department type", e);
            }
        }

        public int DALDepartmentTypeUpdate(TblDepartmentType departmentType)
        {
            try
            {
                TblDepartmentType existingDepartmentType = dBMarketAppEntitiesContext.TblDepartmentType.Find(departmentType.departmentTypeId);
                if(existingDepartmentType != null)
                {
                    existingDepartmentType.departmentTypeName= departmentType.departmentTypeName;   
                    existingDepartmentType.departmentTypeSalaryFactor= departmentType.departmentTypeSalaryFactor;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingDepartmentType.departmentTypeId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the department type", e);
            }
        }

        public int DALDepartmentTypeDelete(TblDepartmentType departmentType)
        {
            try
            {
                TblDepartmentType existingDepartmentType = dBMarketAppEntitiesContext.TblDepartmentType.Find(departmentType.departmentTypeId);
                if (existingDepartmentType != null)
                {
                    dBMarketAppEntitiesContext.TblDepartmentType.Remove(existingDepartmentType);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingDepartmentType.departmentTypeId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the department type", e);
            }
        }
        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
