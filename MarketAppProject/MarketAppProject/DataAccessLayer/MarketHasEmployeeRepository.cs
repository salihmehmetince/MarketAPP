using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class MarketHasEmployeeRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public MarketHasEmployeeRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblMarketHasEmployee> DALMarketHasEmployeeList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblMarketHasEmployee.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the market has employees", e);
            }
        }

        public int DALMarketHasEmployeeAdd(TblMarketHasEmployee marketHasEmployee)
        {
            try
            {
                if(marketHasEmployee!=null)
                {
                    dBMarketAppEntitiesContext.TblMarketHasEmployee.Add(marketHasEmployee);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return marketHasEmployee.marketHasEmployeeId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the market has employee", e);
            }
        }

        public int DALMarketHasEmployeeUpdate(TblMarketHasEmployee marketHasEmployee)
        {
            try
            {
                TblMarketHasEmployee existingMarketHasEmployee=dBMarketAppEntitiesContext.TblMarketHasEmployee.Find(marketHasEmployee.marketHasEmployeeId);
                if(existingMarketHasEmployee!=null)
                {
                    existingMarketHasEmployee.marketId=marketHasEmployee.marketId;
                    existingMarketHasEmployee.employeeId=marketHasEmployee.employeeId;
                    existingMarketHasEmployee.startDate=marketHasEmployee.startDate;
                    existingMarketHasEmployee.endDate=marketHasEmployee.endDate;
                    existingMarketHasEmployee.isActive=marketHasEmployee.isActive;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingMarketHasEmployee.marketHasEmployeeId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the market has employee", e);
            }
        }

        public int DALMarketHasEmployeeDelete(TblMarketHasEmployee marketHasEmployee)
        {
            try
            {
                TblMarketHasEmployee existingMarketHasEmployee = dBMarketAppEntitiesContext.TblMarketHasEmployee.Find(marketHasEmployee.marketHasEmployeeId);
                if (existingMarketHasEmployee != null)
                {
                    dBMarketAppEntitiesContext.TblMarketHasEmployee.Remove(existingMarketHasEmployee);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingMarketHasEmployee.marketHasEmployeeId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the market has employee", e);
            }
        }


        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
