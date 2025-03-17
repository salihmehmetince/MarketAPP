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
    internal class MarketHasEmployeeManager
    {
        public List<TblMarketHasEmployee> BLMarketHasEmployeeList()
        {
            using (var repository = new MarketHasEmployeeRepository())
            {
                return repository.DALMarketHasEmployeeList();
            }
        }

        public int BLMarketHasEmployeeAdd(TblMarketHasEmployee marketHasEmployee)
        {
            if (marketHasEmployee.marketId<0
                || marketHasEmployee.employeeId<0
                || FieldCheck.checkDateTimeField(marketHasEmployee.startDate)
                || FieldCheck.checkDateTimeField(marketHasEmployee.endDate)
                )
            {
                return -1;
            }

            using (var repository = new MarketHasEmployeeRepository())
            {
                return repository.DALMarketHasEmployeeAdd(marketHasEmployee);
            }
        }
        public int BLMarketHasEmployeeUpdate(TblMarketHasEmployee marketHasEmployee)
        {
            if (marketHasEmployee.marketHasEmployeeId<0
                ||marketHasEmployee.marketId<0
                || marketHasEmployee.employeeId<0
                || FieldCheck.checkDateTimeField(marketHasEmployee.startDate)
                || FieldCheck.checkDateTimeField(marketHasEmployee.endDate)
                )
            {
                return -1;
            }

            using (var repository = new MarketHasEmployeeRepository())
            {
                return repository.DALMarketHasEmployeeUpdate(marketHasEmployee);
            }
        }


        public int BLMarketHasEmployeeDelete(TblMarketHasEmployee marketHasEmployee)
        {
            if(marketHasEmployee.marketHasEmployeeId<0)
            {
                return -1;
            }
            using (var repository = new MarketHasEmployeeRepository())
            {
                return repository.DALMarketHasEmployeeDelete(marketHasEmployee);
            }
        }
    }
}
