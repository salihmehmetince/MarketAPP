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
    internal class CompanyTypeManager
    {
        public List<TblCompanyType> BLCompanyTypeList()
        {
            using (var repository = new CompanyTypeRepository())
            {
                return repository.DALCompanyTypeList();
            }
        }

        public int BLCompanyTypeAdd(TblCompanyType companyType)
        {
            if (string.IsNullOrWhiteSpace(companyType.companyTypeName)
                ||companyType.companyTypeName.Length<1
                ||companyType.companyTypeName.Length>30
                )
            {
                return -1;
            }

            using (var repository = new CompanyTypeRepository())
            {
                return repository.DALCompanyTypeAdd(companyType);
            }
        }
        public int BLCompanyTypeUpdate(TblCompanyType companyType)
        {
            if (companyType.companyTypeId<0
                ||string.IsNullOrWhiteSpace(companyType.companyTypeName)
                ||companyType.companyTypeName.Length<1
                ||companyType.companyTypeName.Length>30
                )
            {
                return -1;
            }

            using (var repository = new CompanyTypeRepository())
            {
                return repository.DALCompanyTypeUpdate(companyType);
            }
        }

        public int BLCompanyTypeDelete(TblCompanyType companyType)
        {
            if (companyType.companyTypeId < 0)
            {
                return -1;
            }
            using (var repository = new CompanyTypeRepository())
            {
                return repository.DALCompanyTypeDelete(companyType);
            }
        }
    }
}
