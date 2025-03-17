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
    internal class WarehouseInventoryManager
    {
        public List<TblWarehouseInventory> BLWarehouseInventoryList()
        {
            using (var repository = new WarehouseInventoryRepository())
            {
                return repository.DALWarehouseInventoryList();
            }
        }

        public int BLWarehouseInventoryAdd(TblWarehouseInventory warehouseInventory)
        {
            if (warehouseInventory.warehouseId<0
                ||warehouseInventory.productTemplateId<0
                ||warehouseInventory.totalAmount < 0
                )
            {
                return -1;
            }

            using (var repository = new WarehouseInventoryRepository())
            {
                return repository.DALWarehouseInventoryAdd(warehouseInventory);
            }
        }

        public int BLWarehouseInventoryUpdate(TblWarehouseInventory warehouseInventory)
        {
            if (warehouseInventory.warehouseInventoryId<0
                ||warehouseInventory.warehouseId<0
                ||warehouseInventory.productTemplateId<0
                ||warehouseInventory.totalAmount < 0
                )
            {
                return -1;
            }

            using (var repository = new WarehouseInventoryRepository())
            {
                return repository.DALWarehouseInventoryUpdate(warehouseInventory);
            }
        }
        public int BLWarehouseInventoryDelete(TblWarehouseInventory warehouseInventory)
        {
            if(warehouseInventory.warehouseInventoryId<0)
            {
                return -1;
            }

            using (var repository = new WarehouseInventoryRepository())
            {
                return repository.DALWarehouseInventoryDelete(warehouseInventory);
            }
        }
    }
}
