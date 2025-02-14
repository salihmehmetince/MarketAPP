using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class VehicleRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public VehicleRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblVehicle> DALVehicleList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblVehicle.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the vehicles", e);
            }
        }

        public int DALVehicleAdd(TblVehicle vehicle)
        {
            try
            {
                if(vehicle != null)
                {
                    dBMarketAppEntitiesContext.TblVehicle.Add(vehicle);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return vehicle.vehicleId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the vehicle", e);
            }
        }

        public int DALVehicleUpdate(TblVehicle vehicle)
        {
            try
            {
                TblVehicle existinVehicle = dBMarketAppEntitiesContext.TblVehicle.Find(vehicle.vehicleId);
                if(existinVehicle != null)
                {
                    existinVehicle.vehicleType = vehicle.vehicleType;
                    existinVehicle.vehicleBrand = vehicle.vehicleBrand;
                    existinVehicle.vehicleModel=vehicle.vehicleModel;
                    existinVehicle.vehiclePlateNumber = vehicle.vehiclePlateNumber;
                    existinVehicle.vehicleSerialNumber = vehicle.vehicleSerialNumber;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existinVehicle.vehicleId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the vehicle", e);
            }
        }
        public int DALVehicleDelete(TblVehicle vehicle)
        {
            try
            {
                TblVehicle existinVehicle = dBMarketAppEntitiesContext.TblVehicle.Find(vehicle.vehicleId);
                if(existinVehicle != null)
                {
                    dBMarketAppEntitiesContext.TblVehicle.Remove(existinVehicle);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existinVehicle.vehicleId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the vehicle", e);
            }
        }

        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
