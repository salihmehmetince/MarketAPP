using MarketAppProject.EntityLayer;
using MarketAppProject.HelperFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class ProductBrandManager
    {
        public List<TblProductBrand> BLProductBrandList()
        {
            using (var repository = new ProductBrandRepository())
            {
                return repository.DALProductBrandList();
            }
        }

        public int BLProductBrandAdd(TblProductBrand productBrand)
        {
            if (FieldCheck.checkBasicStringField(productBrand.productBrandName, 1, 40)
                )
            {
                return -1;
            }

            using (var repository = new ProductBrandRepository())
            {
                return repository.DALProductBrandAdd(productBrand);
            }
        }
        public int BLProductBrandUpdate(TblProductBrand productBrand)
        {
            if (productBrand.productBrandId<0
                ||FieldCheck.checkBasicStringField(productBrand.productBrandName, 1, 40)
                )
            {
                return -1;
            }

            using (var repository = new ProductBrandRepository())
            {
                return repository.DALProductBrandUpdate(productBrand);
            }
        }

        public int BLProductBrandDelete(TblProductBrand productBrand)
        {
            using (var repository = new ProductBrandRepository())
            {
                return repository.DALProductBrandDelete(productBrand);
            }
        }
    }
}
