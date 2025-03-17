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
    internal class FactoryProductProductionManager
    {
        public List<TblFactoryProductProduction> BLFactoryProductProductionList()
        {
            using (var repository = new FactoryProductProductionRepository())
            {
                return repository.DALFactoryProductProductionList();
            }
        }

        public int BLFactoryProductProductionAdd(TblFactoryProductProduction factoryProductProduction)
        {
            if (factoryProductProduction.factoryId<0
                ||factoryProductProduction.productTemplateId<0
                || factoryProductProduction.productQuantity<0
                ||FieldCheck.checkDateTimeField(factoryProductProduction.productionDate)
                ||FieldCheck.checkDateTimeField(factoryProductProduction.expirationDate)
                )
            {
                return -1;
            }

            using (var repository = new FactoryProductProductionRepository())
            {
                return repository.DALFactoryProductProductionAdd(factoryProductProduction);
            }
        }
        public int BLFactoryProductProductionUpdate(TblFactoryProductProduction factoryProductProduction)
        {
            if (factoryProductProduction.factoryProductProductionId<0
                ||factoryProductProduction.factoryId<0
                ||factoryProductProduction.productTemplateId<0
                || factoryProductProduction.productQuantity<0
                ||FieldCheck.checkDateTimeField(factoryProductProduction.productionDate)
                ||FieldCheck.checkDateTimeField(factoryProductProduction.expirationDate)
                )
            {
                return -1;
            }

            using (var repository = new FactoryProductProductionRepository())
            {
                return repository.DALFactoryProductProductionUpdate(factoryProductProduction);
            }
        }

        public int BLFactoryProductProductionDelete(TblFactoryProductProduction factoryProductProduction)
        {
            if(factoryProductProduction.factoryProductProductionId<0)
            {
                return -1;
            }
            using (var repository = new FactoryProductProductionRepository())
            {
                return repository.DALFactoryProductProductionDelete(factoryProductProduction);
            }
        }
    }
}
