using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class FactoryHasEmployeeRepository:IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public FactoryHasEmployeeRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblFactoryHasEmployee> DALFactoryHasEmployeeList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblFactoryHasEmployee.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the factory has employees", e);
            }
        }

        public int DALFactoryHasEmployeeAdd(TblFactoryHasEmployee factoryHasEmployee)
        {
            try
            {
                if(factoryHasEmployee != null)
                {
                    dBMarketAppEntitiesContext.TblFactoryHasEmployee.Add(factoryHasEmployee);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return factoryHasEmployee.factoryHasEmployeeId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the factory has employee", e);
            }
        }

        public int DALFactoryHasEmployeeUpdate(TblFactoryHasEmployee factoryHasEmployee)
        {
            try
            {
                TblFactoryHasEmployee existingFactoryHasEmployee = dBMarketAppEntitiesContext.TblFactoryHasEmployee.Find(factoryHasEmployee.factoryHasEmployeeId);
                if(existingFactoryHasEmployee != null)
                {
                    existingFactoryHasEmployee.factoryId = factoryHasEmployee.factoryId;
                    existingFactoryHasEmployee.employeeId = factoryHasEmployee.employeeId;
                    existingFactoryHasEmployee.startDate = factoryHasEmployee.startDate;
                    existingFactoryHasEmployee.endDate = factoryHasEmployee.endDate;
                    existingFactoryHasEmployee.isActive = factoryHasEmployee.isActive;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingFactoryHasEmployee.factoryHasEmployeeId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the factory has employee", e);
            }
        }

        public int DALFactoryHasEmployeeDelete(TblFactoryHasEmployee factoryHasEmployee)
        {
            try
            {
                TblFactoryHasEmployee existingFactoryHasEmployee = dBMarketAppEntitiesContext.TblFactoryHasEmployee.Find(factoryHasEmployee.factoryHasEmployeeId);
                if (existingFactoryHasEmployee != null)
                {
                    dBMarketAppEntitiesContext.TblFactoryHasEmployee.Remove(existingFactoryHasEmployee);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingFactoryHasEmployee.factoryHasEmployeeId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the factory has employee", e);
            }
        }
        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
