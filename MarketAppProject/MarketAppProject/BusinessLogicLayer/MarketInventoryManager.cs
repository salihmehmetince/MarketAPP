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
    internal class MarketInventoryManager
    {
        public List<TblMarketInventory> BLMarketInventoryList()
        {
            using (var repository = new MarketInventoryRepository())
            {
                return repository.DALMarketInventoryList();
            }
        }

        public int BLMarketInventoryAdd(TblMarketInventory marketInventory)
        {
            if (marketInventory.marketId<0
                ||marketInventory.productTemplateId<0
                ||marketInventory.totalAmount < 0
                )
            {
                return -1;
            }

            using (var repository = new MarketInventoryRepository())
            {
                return repository.DALMarketInventoryAdd(marketInventory);
            }
        }
        public int BLMarketInventoryUpdate(TblMarketInventory marketInventory)
        {
            if (marketInventory.marketInventoryId<0
                ||marketInventory.marketId<0
                ||marketInventory.productTemplateId<0
                ||marketInventory.totalAmount < 0
                )
            {
                return -1;
            }

            using (var repository = new MarketInventoryRepository())
            {
                return repository.DALMarketInventoryUpdate(marketInventory);
            }
        }

        public int BLMarketInventoryDelete(TblMarketInventory marketInventory)
        {
            using (var repository = new MarketInventoryRepository())
            {
                return repository.DALMarketInventoryDelete(marketInventory);
            }
        }
    }
}
