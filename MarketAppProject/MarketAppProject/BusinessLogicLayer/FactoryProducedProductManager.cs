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
    internal class FactoryProducedProductManager
    {
        public List<TblFactoryProducedProduct> BLFactoryProducedProductList()
        {
            using (var repository = new FactoryProducedProductRepository())
            {
                return repository.DALFactoryProducedProductList();
            }
        }

        public int BLFactoryProducedProductAdd(TblFactoryProducedProduct factoryProducedProduct)
        {
            if (factoryProducedProduct.factoryId<0
                || factoryProducedProduct.productTemplateId<0
                || !FieldCheck.checkDateTimeField(factoryProducedProduct.productiınDate)
                || !FieldCheck.checkBasicStringField(factoryProducedProduct.barkod,13,13)
                )
            {
                return -1;
            }

            using (var repository = new FactoryProducedProductRepository())
            {
                return repository.DALFactoryProducedProductAdd(factoryProducedProduct);
            }
        }
        public int BLFactoryProducedProductUpdate(TblFactoryProducedProduct factoryProducedProduct)
        {
            if (factoryProducedProduct.factoryProducedProductId<0
                ||factoryProducedProduct.factoryId<0
                || factoryProducedProduct.productTemplateId<0
                || !FieldCheck.checkDateTimeField(factoryProducedProduct.productiınDate)
                || !FieldCheck.checkBasicStringField(factoryProducedProduct.barkod,13,13)
                )
            {
                return -1;
            }

            using (var repository = new FactoryProducedProductRepository())
            {
                return repository.DALFactoryProducedProductUpdate(factoryProducedProduct);
            }
        }

        public int BLFactoryProducedProductDelete(TblFactoryProducedProduct factoryProducedProduct)
        {
            if(factoryProducedProduct.factoryProducedProductId<0)
            {
                return -1;
            }
            using (var repository = new FactoryProducedProductRepository())
            {
                return repository.DALFactoryProducedProductDelete(factoryProducedProduct);
            }
        }
    }
}
