using MarketAppProject.EntityLayer;
using MarketAppProject.HelperFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class ProductUnitManager
    {
        public List<TblProductUnit> BLProductUnitList()
        {
            using (var repository = new ProductUnitRepository())
            {
                return repository.DALProductUnitList();
            }
        }

        public int BLProductUnitAdd(TblProductUnit productUnit)
        {
            if (FieldCheck.checkBasicStringField(productUnit.productUnitName, 1, 40)
                )
            {
                return -1;
            }

            using (var repository = new ProductUnitRepository())
            {
                return repository.DALProductUnitAdd(productUnit);
            }
        }
        public int BLProductUnitUpdate(TblProductUnit productUnit)
        {
            if (productUnit.productUnitId<0
                ||FieldCheck.checkBasicStringField(productUnit.productUnitName, 1, 40)
                )
            {
                return -1;
            }

            using (var repository = new ProductUnitRepository())
            {
                return repository.DALProductUnitUpdate(productUnit);
            }
        }

        public int BLProductUnitDelete(TblProductUnit productUnit)
        {
            using (var repository = new ProductUnitRepository())
            {
                return repository.DALProductUnitDelete(productUnit);
            }
        }
    }
}
