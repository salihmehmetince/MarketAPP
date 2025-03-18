using MarketAppProject.DataAccessLayer;
using MarketAppProject.EntityLayer;
using MarketAppProject.HelperFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.BusinessLogicLayer
{
    internal class FactoryHasEquipmentManager
    {
        public List<TblFactoryHasEquipment> BLFactoryHasEquipmentList()
        {
            using (var repository = new FactoryHasEquipmentRepository())
            {
                return repository.DALFactoryHasEquipmentList();
            }
        }

        public int BLFactoryHasEquipmentAdd(TblFactoryHasEquipment factoryHasEquipment)
        {
            if (factoryHasEquipment.factoryId<0
                || factoryHasEquipment.equipmentId<0
                || !FieldCheck.checkDateTimeField(factoryHasEquipment.purchaseDate)
                || factoryHasEquipment.purchasePrice < 0
                )
            {
                return -1;
            }

            using (var repository = new FactoryHasEquipmentRepository())
            {
                return repository.DALFactoryHasEquipmentAdd(factoryHasEquipment);
            }
        }
        public int BLFactoryHasEquipmentUpdate(TblFactoryHasEquipment factoryHasEquipment)
        {
            if (factoryHasEquipment.factoryHasequipmentId<0
                ||factoryHasEquipment.factoryId<0
                || factoryHasEquipment.equipmentId<0
                || !FieldCheck.checkDateTimeField(factoryHasEquipment.purchaseDate)
                || factoryHasEquipment.purchasePrice < 0
                )
            {
                return -1;
            }

            using (var repository = new FactoryHasEquipmentRepository())
            {
                return repository.DALFactoryHasEquipmentUpdate(factoryHasEquipment);
            }
        }

        public int BLFactoryHasEquipmentDelete(TblFactoryHasEquipment factoryHasEquipment)
        {
            if(factoryHasEquipment.factoryHasequipmentId<0)
            {
                return -1;
            }
            using (var repository = new FactoryHasEquipmentRepository())
            {
                return repository.DALFactoryHasEquipmentDelete(factoryHasEquipment);
            }
        }
    }
}
