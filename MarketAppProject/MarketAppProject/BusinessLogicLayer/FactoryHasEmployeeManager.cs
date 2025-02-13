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
    internal class FactoryHasEmployeeManager
    {
        public List<TblFactoryHasEmployee> BLFactoryHasEmployeeList()
        {
            using (var repository = new FactoryHasEmployeeRepository())
            {
                return repository.DALFactoryHasEmployeeList();
            }
        }

        public int BLFactoryHasEmployeeAdd(TblFactoryHasEmployee factoryHasEmployee)
        {
            if (factoryHasEmployee.factoryId<0
                || factoryHasEmployee.employeeId<0
                || FieldCheck.checkDateTimeField(factoryHasEmployee.startDate)
                || FieldCheck.checkDateTimeField(factoryHasEmployee.endDate)
                )
            {
                return -1;
            }

            using (var repository = new FactoryHasEmployeeRepository())
            {
                return repository.DALFactoryHasEmployeeAdd(factoryHasEmployee);
            }
        }
        public int BLFactoryHasEmployeeUpdate(TblFactoryHasEmployee factoryHasEmployee)
        {
            if (factoryHasEmployee.factoryHasEmployeeId<0
                ||factoryHasEmployee.factoryId<0
                || factoryHasEmployee.employeeId<0
                || FieldCheck.checkDateTimeField(factoryHasEmployee.startDate)
                || FieldCheck.checkDateTimeField(factoryHasEmployee.endDate)
                )
            {
                return -1;
            }

            using (var repository = new FactoryHasEmployeeRepository())
            {
                return repository.DALFactoryHasEmployeeUpdate(factoryHasEmployee);
            }
        }

        public int BLFactoryHasEmployeeDelete(TblFactoryHasEmployee factoryHasEmployee)
        {
            using (var repository = new FactoryHasEmployeeRepository())
            {
                return repository.DALFactoryHasEmployeeDelete(factoryHasEmployee);
            }
        }
    }
}
