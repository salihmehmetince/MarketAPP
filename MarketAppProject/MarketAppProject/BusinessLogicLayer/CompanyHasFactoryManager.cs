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
    internal class CompanyHasFactoryManager
    {
        public List<TblCompanyHasFactory> BLCompanyHasFactoryList()
        {
            using (var repository = new CompanyHasFactoryRepository())
            {
                return repository.DALCompanyHasFactoryList();
            }
        }

        public int BLCompanyHasFactoryAdd(TblCompanyHasFactory companyHasFactory)
        {
            if (companyHasFactory.companyId<1 
                ||companyHasFactory.factoryId<1 
                || !FieldCheck.checkDateTimeField(companyHasFactory.ownershipStartDate)
                || !FieldCheck.checkDateTimeField(companyHasFactory.ownershipEndDate)
                )
            {
                return -1;
            }

            using (var repository = new CompanyHasFactoryRepository())
            {
                return repository.DALCompanyHasFactoryAdd(companyHasFactory);
            }
        }
        
        public int BLCompanyHasFactoryUpdate(TblCompanyHasFactory companyHasFactory)
        {
            if (companyHasFactory.companyHasFactoryId<0
                ||companyHasFactory.companyId<1 
                ||companyHasFactory.factoryId<1 
                || !FieldCheck.checkDateTimeField(companyHasFactory.ownershipStartDate)
                || !FieldCheck.checkDateTimeField(companyHasFactory.ownershipEndDate)
                )
            {
                return -1;
            }

            using (var repository = new CompanyHasFactoryRepository())
            {
                return repository.DALCompanyHasFactoryUpdate(companyHasFactory);
            }
        }

        public int BLCompanyHasFactoryDelete(TblCompanyHasFactory companyHasFactory)
        {
            if (companyHasFactory.companyHasFactoryId < 0)
            {
                return -1;
            }
            using (var repository = new CompanyHasFactoryRepository())
            {
                return repository.DALCompanyHasFactoryDelete(companyHasFactory);
            }
        }

    }
}
