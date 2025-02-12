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
    internal class CompanyHasMarketManager
    {
        public List<TblCompanyHasMarket> BLCompanyHasMarketList()
        {
            using (var repository = new CompanyHasMarketRepository())
            {
                return repository.DALCompanyHasMarketList();
            }
        }

        public int BLCompanyHasMarketAdd(TblCompanyHasMarket companyHasMarket)
        {
            if (companyHasMarket.companyId < 1
                || companyHasMarket.marketId < 1
                || FieldCheck.checkDateTimeField(companyHasMarket.ownershipStartDate)
                || FieldCheck.checkDateTimeField(companyHasMarket.ownershipEndDate)
                )
            {
                return -1;
            }

            using (var repository = new CompanyHasMarketRepository())
            {
                return repository.DALCompanyHasMarketAdd(companyHasMarket);
            }
        }

        public int BLCompanyHasMarketUpdate(TblCompanyHasMarket companyHasMarket)
        {
            if (companyHasMarket.companyHasMarketId < 0
                || companyHasMarket.companyId < 1
                || companyHasMarket.marketId < 1
                || FieldCheck.checkDateTimeField(companyHasMarket.ownershipStartDate)
                || FieldCheck.checkDateTimeField(companyHasMarket.ownershipEndDate)
                )
            {
                return -1;
            }

            using (var repository = new CompanyHasMarketRepository())
            {
                return repository.DALCompanyHasMarketUpdate(companyHasMarket);
            }
        }

        public int BLCompanyHasMarketDelete(TblCompanyHasMarket companyHasMarket)
        {
            using (var repository = new CompanyHasMarketRepository())
            {
                return repository.DALCompanyHasMarketDelete(companyHasMarket);
            }
        }
    }
}
