using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class FactoryHasVehicleRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public FactoryHasVehicleRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblFactoryHasVehicle> DALFactoryHasVehicleList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblFactoryHasVehicle.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the factory has vehicles", e);
            }
        }

        public int DALFactoryHasVehicleAdd(TblFactoryHasVehicle factoryHasVehicle)
        {
            try
            {
                if(factoryHasVehicle != null)
                {
                    dBMarketAppEntitiesContext.TblFactoryHasVehicle.Add(factoryHasVehicle);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return factoryHasVehicle.factoryHasVehicleId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the factory has vehicle", e);
            }
        }

        public int DALFactoryHasVehicleUpdate(TblFactoryHasVehicle factoryHasVehicle)
        {
            try
            {
                TblFactoryHasVehicle existingFactoryHasVehicle = dBMarketAppEntitiesContext.TblFactoryHasVehicle.Find(factoryHasVehicle.factoryHasVehicleId);
                if(existingFactoryHasVehicle != null)
                {
                    existingFactoryHasVehicle.factoryId = factoryHasVehicle.factoryId;
                    existingFactoryHasVehicle.vehicleId = factoryHasVehicle.vehicleId;
                    existingFactoryHasVehicle.vehiclePurchaseMilAge = factoryHasVehicle.vehiclePurchaseMilAge;
                    existingFactoryHasVehicle.vehiclePurchasePrice = factoryHasVehicle.vehiclePurchasePrice;
                    existingFactoryHasVehicle.vehiclePurchaseDate = factoryHasVehicle.vehiclePurchaseDate;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingFactoryHasVehicle.factoryHasVehicleId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the factory has vehicle", e);
            }
        }

        public int DALFactoryHasVehicleDelete(TblFactoryHasVehicle factoryHasVehicle)
        {
            try
            {
                TblFactoryHasVehicle existingFactoryHasVehicle = dBMarketAppEntitiesContext.TblFactoryHasVehicle.Find(factoryHasVehicle.factoryHasVehicleId);
                if (existingFactoryHasVehicle != null)
                {
                    dBMarketAppEntitiesContext.TblFactoryHasVehicle.Remove(existingFactoryHasVehicle);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingFactoryHasVehicle.factoryHasVehicleId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the factory has vehicle", e);
            }
        }
        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
