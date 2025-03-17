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
    internal class FactoryInventoryManager
    {
        public List<TblFactoryInventory> BLFactoryInventoryList()
        {
            using (var repository = new FactoryInventoryRepository())
            {
                return repository.DALFactoryInventoryList();
            }
        }

        public int BLFactoryInventoryAdd(TblFactoryInventory factoryInventory)
        {
            if (factoryInventory.factoryId<0
                ||factoryInventory.productTemplateId<0
                || factoryInventory.totalAmount<0
                )
            {
                return -1;
            }

            using (var repository = new FactoryInventoryRepository())
            {
                return repository.DALFactoryInventoryAdd(factoryInventory);
            }
        }
        public int BLFactoryInventoryUpdate(TblFactoryInventory factoryInventory)
        {
            if (factoryInventory.factoryInventoryId<0
                ||factoryInventory.factoryId<0
                ||factoryInventory.productTemplateId<0
                || factoryInventory.totalAmount<0
                )
            {
                return -1;
            }

            using (var repository = new FactoryInventoryRepository())
            {
                return repository.DALFactoryInventoryUpdate(factoryInventory);
            }
        }

        public int BLFactoryInventoryDelete(TblFactoryInventory factoryInventory)
        {
            if ((factoryInventory.factoryInventoryId<0))
            {
                return -1;
            }
            using (var repository = new FactoryInventoryRepository())
            {
                return repository.DALFactoryInventoryDelete(factoryInventory);
            }
        }
    }
}
