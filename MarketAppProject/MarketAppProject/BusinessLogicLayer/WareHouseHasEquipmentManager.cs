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
    internal class WareHouseHasEquipmentManager
    {
        public List<TblWareHouseHasEquipment> BLWarehouseHasEquipmentList()
        {
            using (var repository = new WarehouseHasEquipmentRepository())
            {
                return repository.DALWarehouseHasequipmentList();
            }
        }

        public int BLWarehouseHasEquipmentAdd(TblWareHouseHasEquipment wareHouseHasEquipment)
        {
            if (wareHouseHasEquipment.warehouseId<0
                ||wareHouseHasEquipment.equipmentId<0
                ||!FieldCheck.checkDateTimeField(wareHouseHasEquipment.purchaseDate)
                ||wareHouseHasEquipment.purchasePrice < 0
                )
            {
                return -1;
            }

            using (var repository = new WarehouseHasEquipmentRepository())
            {
                return repository.DALWarehouseHasequipmentAdd(wareHouseHasEquipment);
            }
        }
        public int BLWarehouseHasEquipmentUpdate(TblWareHouseHasEquipment wareHouseHasEquipment)
        {
            if (wareHouseHasEquipment.warehouseHasequipmentId<0
                ||wareHouseHasEquipment.warehouseId<0
                ||wareHouseHasEquipment.equipmentId<0
                ||!FieldCheck.checkDateTimeField(wareHouseHasEquipment.purchaseDate)
                ||wareHouseHasEquipment.purchasePrice < 0
                )
            {
                return -1;
            }

            using (var repository = new WarehouseHasEquipmentRepository())
            {
                return repository.DALWarehouseHasequipmentUpdate(wareHouseHasEquipment);
            }
        }

        public int BLWarehouseHasEquipmentDelete(TblWareHouseHasEquipment wareHouseHasEquipment)
        {
            if(wareHouseHasEquipment.warehouseHasequipmentId<0)
            {
                return -1;
            }
            using (var repository = new WarehouseHasEquipmentRepository())
            {
                return repository.DALWarehouseHasequipmentDelete(wareHouseHasEquipment);
            }
        }
    }
}
