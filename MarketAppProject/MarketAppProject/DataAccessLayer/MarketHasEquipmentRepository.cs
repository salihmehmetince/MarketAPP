using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class MarketHasEquipmentRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public MarketHasEquipmentRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblMarketHasEquipment> DALMarketHasEquipmentList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblMarketHasEquipment.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the market has equipments", e);
            }
        }

        public int DALMarketHasEquipmentAdd(TblMarketHasEquipment marketHasEquipment)
        {
            try
            {
                if(marketHasEquipment != null)
                {
                    dBMarketAppEntitiesContext.TblMarketHasEquipment.Add(marketHasEquipment);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return marketHasEquipment.marketHasEquipmentId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the market has equipment", e);
            }
        }

        public int DALMarketHasEquipmentUpdate(TblMarketHasEquipment marketHasEquipment)
        {
            try
            {
                TblMarketHasEquipment existingMarketHasEquipment = dBMarketAppEntitiesContext.TblMarketHasEquipment.Find(marketHasEquipment.marketHasEquipmentId);
                if(existingMarketHasEquipment!=null)
                {
                    existingMarketHasEquipment.marketId = marketHasEquipment.marketId;
                    existingMarketHasEquipment.equipmentId = marketHasEquipment.equipmentId;
                    existingMarketHasEquipment.purchasePrice = marketHasEquipment.purchasePrice;
                    existingMarketHasEquipment.purchaseDate = marketHasEquipment.purchaseDate;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingMarketHasEquipment.marketHasEquipmentId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the market has equipment", e);
            }
        }

        public int DALMarketHasEquipmentDelete(TblMarketHasEquipment marketHasEquipment)
        {
            try
            {
                TblMarketHasEquipment existingMarketHasEquipment = dBMarketAppEntitiesContext.TblMarketHasEquipment.Find(marketHasEquipment.marketHasEquipmentId);
                if (existingMarketHasEquipment != null)
                {
                    dBMarketAppEntitiesContext.TblMarketHasEquipment.Remove(existingMarketHasEquipment);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingMarketHasEquipment.marketHasEquipmentId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the market has equipment", e);
            }
        }


        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
