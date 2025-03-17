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
    internal class CompanyOwnerHasCompanyManager
    {
        public List<TblCompanyOwerHasCompany> BLCompanyOwerHasCompanyList()
        {
            using (var repository = new CompanyOwnerHasCompanyRepository())
            {
                return repository.DALCompanyOwnerHasCompanyList();
            }
        }

        public int BLCompanyOwerHasCompanyAdd(TblCompanyOwerHasCompany companyOwerHasCompany)
        {
            if (companyOwerHasCompany.companyOwner<1
                || companyOwerHasCompany.company<1
                || companyOwerHasCompany.companyOwnerPercent<0
                || companyOwerHasCompany.companyOwnerPercent>100
                || FieldCheck.checkDateTimeField(companyOwerHasCompany.startDate)
                || FieldCheck.checkDateTimeField(companyOwerHasCompany.endDate)
                )
            {
                return -1;
            }

            using (var repository = new CompanyOwnerHasCompanyRepository())
            {
                return repository.DALCompanyOwnerHasCompanyAdd(companyOwerHasCompany);
            }
        }
        public int BLCompanyOwerHasCompanyUpdate(TblCompanyOwerHasCompany companyOwerHasCompany)
        {
            if (companyOwerHasCompany.CompanyOwerHasCompanyId<0
                ||companyOwerHasCompany.companyOwner<1
                || companyOwerHasCompany.company<1
                || companyOwerHasCompany.companyOwnerPercent<0
                || companyOwerHasCompany.companyOwnerPercent>100
                || FieldCheck.checkDateTimeField(companyOwerHasCompany.startDate)
                || FieldCheck.checkDateTimeField(companyOwerHasCompany.endDate)
                )
            {
                return -1;
            }

            using (var repository = new CompanyOwnerHasCompanyRepository())
            {
                return repository.DALCompanyOwnerHasCompanyUpdate(companyOwerHasCompany);
            }
        }

        public int BLCompanyOwerHasCompanyDelete(TblCompanyOwerHasCompany companyOwerHasCompany)
        {
            if(companyOwerHasCompany.CompanyOwerHasCompanyId<0)
            {
                return -1;
            }
            using (var repository = new CompanyOwnerHasCompanyRepository())
            {
                return repository.DALCompanyOwnerHasCompanyDelete(companyOwerHasCompany);
            }
        }
    }
}
