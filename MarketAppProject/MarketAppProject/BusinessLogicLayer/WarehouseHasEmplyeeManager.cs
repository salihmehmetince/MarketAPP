using MarketAppProject.DataAccessLayer;
using MarketAppProject.EntityLayer;
using MarketAppProject.HelperFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.BusinessLogicLayer
{
    internal class WarehouseHasEmplyeeManager
    {
        public List<TblWarehouseHasEmployee> BLWarehouseHasEmployeeList()
        {
            using (var repository = new WarehouseHasEmplyeeRepository())
            {
                return repository.DALWarehouseHasEmployeeList();
            }
        }

        public int BLWarehouseHasEmployeeAdd(TblWarehouseHasEmployee warehouseHasEmployee)
        {
            if (warehouseHasEmployee.warehouseId<0
                ||warehouseHasEmployee.employeeId<0
                ||FieldCheck.checkDateTimeField(warehouseHasEmployee.startDate)
                ||FieldCheck.checkDateTimeField(warehouseHasEmployee.endDate)
                )
            {
                return -1;
            }

            using (var repository = new WarehouseHasEmplyeeRepository())
            {
                return repository.DALWarehouseHasEmployeeAdd(warehouseHasEmployee);
            }
        }
        public int BLWarehouseHasEmployeeUpdate(TblWarehouseHasEmployee warehouseHasEmployee)
        {
            if (warehouseHasEmployee.warehouseHasEmployeeId<0
                ||warehouseHasEmployee.warehouseId<0
                ||warehouseHasEmployee.employeeId<0
                ||FieldCheck.checkDateTimeField(warehouseHasEmployee.startDate)
                ||FieldCheck.checkDateTimeField(warehouseHasEmployee.endDate)
                )
            {
                return -1;
            }

            using (var repository = new WarehouseHasEmplyeeRepository())
            {
                return repository.DALWarehouseHasEmployeeUpdate(warehouseHasEmployee);
            }
        }
        public int BLWarehouseHasEmployeeDelete(TblWarehouseHasEmployee warehouseHasEmployee)
        {
            if(warehouseHasEmployee.warehouseHasEmployeeId<0)
            {
                return -1;
            }
            using (var repository = new WarehouseHasEmplyeeRepository())
            {
                return repository.DALWarehouseHasEmployeeDelete(warehouseHasEmployee);
            }
        }
    }
}
