using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class WarehouseHasEmplyeeRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public WarehouseHasEmplyeeRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();    
        }

        public List<TblWarehouseHasEmployee> DALWarehouseHasEmployeeList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblWarehouseHasEmployee.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the warehouse has employees", e);
            }
        }

        public int DALWarehouseHasEmployeeAdd(TblWarehouseHasEmployee warehouseHasEmployee)
        {
            try
            {
                if(warehouseHasEmployee!=null)
                {
                    dBMarketAppEntitiesContext.TblWarehouseHasEmployee.Add(warehouseHasEmployee);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return warehouseHasEmployee.warehouseHasEmployeeId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the warehouse has employee", e);
            }
        }

        public int DALWarehouseHasEmployeeUpdate(TblWarehouseHasEmployee warehouseHasEmployee)
        {
            try
            {
                TblWarehouseHasEmployee existingWarehousHasEmployee = dBMarketAppEntitiesContext.TblWarehouseHasEmployee.Find(warehouseHasEmployee.warehouseHasEmployeeId);
                if(existingWarehousHasEmployee!=null)
                {
                    existingWarehousHasEmployee.warehouseId = warehouseHasEmployee.warehouseId;
                    existingWarehousHasEmployee.employeeId=warehouseHasEmployee.employeeId;
                    existingWarehousHasEmployee.startDate=warehouseHasEmployee.startDate;
                    existingWarehousHasEmployee.endDate=warehouseHasEmployee.endDate;
                    existingWarehousHasEmployee.isActive=warehouseHasEmployee.isActive;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingWarehousHasEmployee.warehouseHasEmployeeId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the warehouse has employee", e);
            }
        }

        public int DALWarehouseHasEmployeeDelete(TblWarehouseHasEmployee warehouseHasEmployee)
        {
            try
            {
                TblWarehouseHasEmployee existingWarehousHasEmployee = dBMarketAppEntitiesContext.TblWarehouseHasEmployee.Find(warehouseHasEmployee.warehouseHasEmployeeId);
                if (existingWarehousHasEmployee != null)
                {
                    dBMarketAppEntitiesContext.TblWarehouseHasEmployee.Remove(existingWarehousHasEmployee);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingWarehousHasEmployee.warehouseHasEmployeeId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the warehouse has employee", e);
            }
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
