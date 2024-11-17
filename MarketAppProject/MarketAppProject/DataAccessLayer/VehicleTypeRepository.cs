using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class VehicleTypeRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public VehicleTypeRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();    
        }

        public List<TblVehicleType> DALVehicleTypeList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblVehicleType.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the vehicle types", e);
            }
        }

        public int DALVehicleTypeAdd(TblVehicleType vehicleType)
        {
            try
            {
                if(vehicleType != null)
                {
                    dBMarketAppEntitiesContext.TblVehicleType.Add(vehicleType);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return vehicleType.vehicleTypeId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the vehicle type", e);
            }
        }

        public int DALVehicleTypeUpdate(TblVehicleType vehicleType)
        {
            try
            {
                TblVehicleType existingVehicleType = dBMarketAppEntitiesContext.TblVehicleType.Find(vehicleType.vehicleTypeId);
                if(existingVehicleType!=null)
                {
                    existingVehicleType.vehicleTypeName = vehicleType.vehicleTypeName;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingVehicleType.vehicleTypeId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the vehicle type", e);
            }
        }

        public int DALVehicleTypeDelete(TblVehicleType vehicleType)
        {
            try
            {
                TblVehicleType existingVehicleType = dBMarketAppEntitiesContext.TblVehicleType.Find(vehicleType.vehicleTypeId);
                if (existingVehicleType != null)
                {
                    dBMarketAppEntitiesContext.TblVehicleType.Remove(existingVehicleType);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingVehicleType.vehicleTypeId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the vehicle type", e);
            }
        }
        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
