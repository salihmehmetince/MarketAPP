using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class WarehouseHasEquipmentRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public WarehouseHasEquipmentRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblWareHouseHasEquipment> DALWarehouseHasequipmentList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblWareHouseHasEquipment.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the warehouse has equipments", e);
            }
        }

        public int DALWarehouseHasequipmentAdd(TblWareHouseHasEquipment wareHouseHasEquipment)
        {
            try
            {
                if(wareHouseHasEquipment!=null)
                {
                    dBMarketAppEntitiesContext.TblWareHouseHasEquipment.Add(wareHouseHasEquipment);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return wareHouseHasEquipment.warehouseHasequipmentId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the warehouse has equipment", e);
            }
        }

        public int DALWarehouseHasequipmentUpdate(TblWareHouseHasEquipment wareHouseHasEquipment)
        {
            try
            {
                TblWareHouseHasEquipment existingWarehouseHasEquipment = dBMarketAppEntitiesContext.TblWareHouseHasEquipment.Find(wareHouseHasEquipment.warehouseHasequipmentId);
                if(existingWarehouseHasEquipment!=null)
                {
                    existingWarehouseHasEquipment.warehouseId = wareHouseHasEquipment.warehouseId;
                    existingWarehouseHasEquipment.equipmentId = wareHouseHasEquipment.equipmentId;
                    existingWarehouseHasEquipment.purchasePrice = wareHouseHasEquipment.purchasePrice;
                    existingWarehouseHasEquipment.purchaseDate = wareHouseHasEquipment.purchaseDate;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingWarehouseHasEquipment.warehouseHasequipmentId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the warehouse has equipment", e);
            }
        }

        public int DALWarehouseHasequipmentDelete(TblWareHouseHasEquipment wareHouseHasEquipment)
        {
            try
            {
                TblWareHouseHasEquipment existingWarehouseHasEquipment = dBMarketAppEntitiesContext.TblWareHouseHasEquipment.Find(wareHouseHasEquipment.warehouseHasequipmentId);
                if (existingWarehouseHasEquipment != null)
                {
                    dBMarketAppEntitiesContext.TblWareHouseHasEquipment.Remove(existingWarehouseHasEquipment);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingWarehouseHasEquipment.warehouseHasequipmentId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the warehouse has equipment", e);
            }
        }
        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
