using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class EquipmentRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public EquipmentRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();    
        }

        public List<TblEquipment> DALEquipmentList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblEquipment.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the equipments", e);
            }
        }

        public int DALEquipmentAdd(TblEquipment equipment)
        {
            try
            {
                if(equipment!=null)
                {
                    dBMarketAppEntitiesContext.TblEquipment.Add(equipment);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return equipment.equipmentId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the equipment", e);
            }
        }

        public int DALEquipmentUpdate(TblEquipment equipment)
        {
            try
            {
                TblEquipment existingEquipment = dBMarketAppEntitiesContext.TblEquipment.Find(equipment.equipmentId);
                if(existingEquipment!=null)
                {
                    existingEquipment.equipmentName = equipment.equipmentName;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingEquipment.equipmentId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the equipment", e);
            }
        }

        public int DALEquipmentDelete(TblEquipment equipment)
        {
            try
            {
                TblEquipment existingEquipment = dBMarketAppEntitiesContext.TblEquipment.Find(equipment.equipmentId);
                if (existingEquipment != null)
                {
                    dBMarketAppEntitiesContext.TblEquipment.Remove(existingEquipment);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingEquipment.equipmentId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the equipment", e);
            }
        }
        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
