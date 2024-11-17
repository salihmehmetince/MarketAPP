using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class VehicleModelRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;
        public VehicleModelRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();    
        }

        public List<TblVehicleModel> DALVehicleModelList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblVehicleModel.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the vehicle models", e);
            }
        }

        public int DALVehicleModelAdd(TblVehicleModel vehicleModel)
        {
            try
            {
                if(vehicleModel != null)
                {
                    dBMarketAppEntitiesContext.TblVehicleModel.Add(vehicleModel);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return vehicleModel.vehicleModelId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the vehicle model", e);
            }
        }

        public int DALVehicleModelUpdate(TblVehicleModel vehicleModel)
        {
            try
            {
                TblVehicleModel existingVehicleModel=dBMarketAppEntitiesContext.TblVehicleModel.Find(vehicleModel.vehicleModelId);
                if (existingVehicleModel != null)
                {
                    existingVehicleModel.vehicleModelName = vehicleModel.vehicleModelName;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingVehicleModel.vehicleModelId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the vehicle model", e);
            }
        }

        public int DALVehicleModelDelete(TblVehicleModel vehicleModel)
        {
            try
            {
                TblVehicleModel existingVehicleModel = dBMarketAppEntitiesContext.TblVehicleModel.Find(vehicleModel.vehicleModelId);
                if (existingVehicleModel != null)
                {
                    dBMarketAppEntitiesContext.TblVehicleModel.Remove(existingVehicleModel);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingVehicleModel.vehicleModelId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the vehicle model", e);
            }
        }


        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
