using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class MarketHasVehicleRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public MarketHasVehicleRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblMarketHasVehicle> DALMarketHasVehicleList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblMarketHasVehicle.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the market has vehicles", e);
            }
        }

        public int DALMarketHasVehicleAdd(TblMarketHasVehicle marketHasVehicle)
        {
            try
            {
                if(marketHasVehicle != null)
                {
                    dBMarketAppEntitiesContext.TblMarketHasVehicle.Add(marketHasVehicle);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return marketHasVehicle.marketHasVehicleId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the market has vehicle", e);
            }
        }

        public int DALMarketHasVehicleUpdate(TblMarketHasVehicle marketHasVehicle)
        {
            try
            {
                TblMarketHasVehicle existingMarketHasvehicle=dBMarketAppEntitiesContext.TblMarketHasVehicle.Find(marketHasVehicle.marketHasVehicleId);
                if(existingMarketHasvehicle != null)
                {
                    existingMarketHasvehicle.marketId = marketHasVehicle.marketId;
                    existingMarketHasvehicle.vehicleId = marketHasVehicle.vehicleId;
                    existingMarketHasvehicle.vehiclePurchaseMilAge= marketHasVehicle.vehiclePurchaseMilAge;
                    existingMarketHasvehicle.vehiclePurchasePrice= marketHasVehicle.vehiclePurchasePrice;
                    existingMarketHasvehicle.vehiclePurchaseDate= marketHasVehicle.vehiclePurchaseDate;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingMarketHasvehicle.marketHasVehicleId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the market has vehicle", e);
            }
        }

        public int DALMarketHasVehicleDelete(TblMarketHasVehicle marketHasVehicle)
        {
            try
            {
                TblMarketHasVehicle existingMarketHasvehicle = dBMarketAppEntitiesContext.TblMarketHasVehicle.Find(marketHasVehicle.marketHasVehicleId);
                if (existingMarketHasvehicle != null)
                {
                    dBMarketAppEntitiesContext.TblMarketHasVehicle.Remove(existingMarketHasvehicle);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingMarketHasvehicle.marketHasVehicleId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the market has vehicle", e);
            }
        }
        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
