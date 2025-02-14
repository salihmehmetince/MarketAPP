using MarketAppProject.EntityLayer;
using MarketAppProject.HelperFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class ProductTypeManager
    {
        public List<TblProductType> BLProductTypeList()
        {
            using (var repository = new ProductTypeRepository())
            {
                return repository.DALProductTypeList();
            }
        }

        public int BLProductTypeAdd(TblProductType productType)
        {
            if (FieldCheck.checkBasicStringField(productType.productTypeName, 1, 40)
                )
            {
                return -1;
            }

            using (var repository = new ProductTypeRepository())
            {
                return repository.DALProductTypeAdd(productType);
            }
        }
        public int BLProductTypeUpdate(TblProductType productType)
        {
            if (productType.productTypeId<0
                ||FieldCheck.checkBasicStringField(productType.productTypeName, 1, 40)
                )
            {
                return -1;
            }

            using (var repository = new ProductTypeRepository())
            {
                return repository.DALProductTypeUpdate(productType);
            }
        }

        public int BLProductTypeDelete(TblProductType productType)
        {
            using (var repository = new ProductTypeRepository())
            {
                return repository.DALProductTypeDelete(productType);
            }
        }
    }
}
