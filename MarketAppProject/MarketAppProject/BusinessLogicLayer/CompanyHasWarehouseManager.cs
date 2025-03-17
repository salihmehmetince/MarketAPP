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
    internal class CompanyHasWarehouseManager
    {
        public List<TblCompanyHasWarehouse> BLCompanyHasWarehouseList()
        {
            using (var repository = new CompanyHasWarehouseRepository())
            {
                return repository.DALCompanyHasWarehouseList();
            }
        }

        public int BLCompanyHasWarehouseAdd(TblCompanyHasWarehouse companyHasWarehouse)
        {
            if (companyHasWarehouse.companyId < 1
                || companyHasWarehouse.warehouseId < 1
                || FieldCheck.checkDateTimeField(companyHasWarehouse.ownershipStartDate)
                || FieldCheck.checkDateTimeField(companyHasWarehouse.ownershipEndDate)
                )
            {
                return -1;
            }

            using (var repository = new CompanyHasWarehouseRepository())
            {
                return repository.DALCompanyHasWarehouseAdd(companyHasWarehouse);
            }
        }

        public int BLCompanyHasWarehouseUpdate(TblCompanyHasWarehouse companyHasWarehouse)
        {
            if (companyHasWarehouse.companyHasWarehouseId < 0
                || companyHasWarehouse.companyId < 1
                || companyHasWarehouse.warehouseId < 1
                || FieldCheck.checkDateTimeField(companyHasWarehouse.ownershipStartDate)
                || FieldCheck.checkDateTimeField(companyHasWarehouse.ownershipEndDate)
                )
            {
                return -1;
            }

            using (var repository = new CompanyHasWarehouseRepository())
            {
                return repository.DALCompanyHasWarehouseUpdate(companyHasWarehouse);
            }
        }

        public int BLCompanyHasWarehouseDelete(TblCompanyHasWarehouse companyHasWarehouse)
        {
            if (companyHasWarehouse.companyHasWarehouseId < 0)
            {
                return -1;
            }
            using (var repository = new CompanyHasWarehouseRepository())
            {
                return repository.DALCompanyHasWarehouseDelete(companyHasWarehouse);
            }
        }
    }
}
