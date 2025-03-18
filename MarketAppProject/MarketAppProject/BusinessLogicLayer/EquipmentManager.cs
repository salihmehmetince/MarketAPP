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
    internal class EquipmentManager
    {
        public List<TblEquipment> BLEquipmentList()
        {
            using (var repository = new EquipmentRepository())
            {
                return repository.DALEquipmentList();
            }
        }

        public int BLEquipmentAdd(TblEquipment equipment)
        {
            if (!FieldCheck.checkBasicStringField(equipment.equipmentName, 1, 40)
                )
            {
                return -1;
            }

            using (var repository = new EquipmentRepository())
            {
                return repository.DALEquipmentAdd(equipment);
            }
        }
        public int BLEquipmentUpdate(TblEquipment equipment)
        {
            if (equipment.equipmentId<0
                ||!FieldCheck.checkBasicStringField(equipment.equipmentName, 1, 40)
                )
            {
                return -1;
            }

            using (var repository = new EquipmentRepository())
            {
                return repository.DALEquipmentUpdate(equipment);
            }
        }

        public int BLEquipmentDelete(TblEquipment equipment)
        {
            if(equipment.equipmentId<0)
            {
                return-1;
            }
            using (var repository = new EquipmentRepository())
            {
                return repository.DALEquipmentDelete(equipment);
            }
        }
    }
}
