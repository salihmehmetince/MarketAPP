using MarketAppProject.EntityLayer;
using MarketAppProject.HelperFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class ProductKindManager
    {
        public List<TblProductKind> BLProductKindList()
        {
            using (var repository = new ProductKindRepository())
            {
                return repository.DALProductKindList();
            }
        }

        public int BLProductKindAdd(TblProductKind productKind)
        {
            if (FieldCheck.checkBasicStringField(productKind.productKindName, 1, 40)
                )
            {
                return -1;
            }

            using (var repository = new ProductKindRepository())
            {
                return repository.DALProductKindAdd(productKind);
            }
        }
        public int BLProductKindUpdate(TblProductKind productKind)
        {
            if (productKind.productKindId<0
                ||FieldCheck.checkBasicStringField(productKind.productKindName, 1, 40)
                )
            {
                return -1;
            }

            using (var repository = new ProductKindRepository())
            {
                return repository.DALProductKindUpdate(productKind);
            }
        }

        public int BLProductKindDelete(TblProductKind productKind)
        {
            using (var repository = new ProductKindRepository())
            {
                return repository.DALProductKindDelete(productKind);
            }
        }
    }
}
