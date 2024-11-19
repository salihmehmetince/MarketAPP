using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class FactoryHasEquipmentRepository : IDisposable
    {

        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public FactoryHasEquipmentRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblFactoryHasEquipment> DALFactoryHasEquipmentList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblFactoryHasEquipment.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the factory has equipments", e);
            }
        }

        public int DALFactoryHasEquipmentAdd(TblFactoryHasEquipment factoryHasEquipment)
        {
            try
            {
                if(factoryHasEquipment != null)
                {
                    dBMarketAppEntitiesContext.TblFactoryHasEquipment.Add(factoryHasEquipment);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return factoryHasEquipment.factoryHasequipmentId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the factory has equipment", e);
            }
        }

        public int DALFactoryHasEquipmentUpdate(TblFactoryHasEquipment factoryHasEquipment)
        {
            try
            {
                TblFactoryHasEquipment existingFactoryHasEquipment=dBMarketAppEntitiesContext.TblFactoryHasEquipment.Find(factoryHasEquipment.factoryHasequipmentId);
                if(existingFactoryHasEquipment != null)
                {
                    existingFactoryHasEquipment.factoryId = factoryHasEquipment.factoryId;
                    existingFactoryHasEquipment.equipmentId=factoryHasEquipment.equipmentId;
                    existingFactoryHasEquipment.purchasePrice = factoryHasEquipment.purchasePrice;
                    existingFactoryHasEquipment.purchaseDate = factoryHasEquipment.purchaseDate;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingFactoryHasEquipment.factoryHasequipmentId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the factory has equipment", e);
            }
        }

        public int DALFactoryHasEquipmentDelete(TblFactoryHasEquipment factoryHasEquipment)
        {
            try
            {
                TblFactoryHasEquipment existingFactoryHasEquipment = dBMarketAppEntitiesContext.TblFactoryHasEquipment.Find(factoryHasEquipment.factoryHasequipmentId);
                if (existingFactoryHasEquipment != null)
                {
                    dBMarketAppEntitiesContext.TblFactoryHasEquipment.Remove(existingFactoryHasEquipment);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingFactoryHasEquipment.factoryHasequipmentId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the factory has equipment", e);
            }
        }

        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
