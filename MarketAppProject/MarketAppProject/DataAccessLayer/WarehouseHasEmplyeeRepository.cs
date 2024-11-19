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

        public int DALWarehouseHasEmployeeList
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
