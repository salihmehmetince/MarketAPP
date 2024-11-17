using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class VehicleBrandRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public VehicleBrandRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();    
        }

        public List<TblVehicleBrand> DALVehicleBrandList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblVehicleBrand.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the vehicle brands", e);
            }
        }

        public int DALVehicleBrandAdd(TblVehicleBrand vehicleBrand)
        {
            try
            {
                if(vehicleBrand != null)
                {
                    dBMarketAppEntitiesContext.TblVehicleBrand.Add(vehicleBrand);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return vehicleBrand.vehicleBrandId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the vehicle brand", e);
            }
        }

        public int DALVehicleBrandUpdate(TblVehicleBrand vehicleBrand)
        {
            try
            {
                TblVehicleBrand existingVehicleBrand = dBMarketAppEntitiesContext.TblVehicleBrand.Find(vehicleBrand.vehicleBrandId);
                if(existingVehicleBrand!=null)
                {
                    existingVehicleBrand.vehicleBrandName = vehicleBrand.vehicleBrandName;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingVehicleBrand.vehicleBrandId; 
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the vehicle brand", e);
            }
        }

        public int DALVehicleBrandDelete(TblVehicleBrand vehicleBrand)
        {
            try
            {
                TblVehicleBrand existingVehicleBrand = dBMarketAppEntitiesContext.TblVehicleBrand.Find(vehicleBrand.vehicleBrandId);
                if (existingVehicleBrand != null)
                {
                    dBMarketAppEntitiesContext.TblVehicleBrand.Remove(existingVehicleBrand);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingVehicleBrand.vehicleBrandId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the vehicle brand", e);
            }
        }

        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
