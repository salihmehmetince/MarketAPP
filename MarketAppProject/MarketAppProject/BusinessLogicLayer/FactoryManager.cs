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
    internal class FactoryManager
    {
        public List<TblFactory> BLFactoryList()
        {
            using (var repository = new FactoryRepository())
            {
                return repository.DALFactoryList();
            }
        }

        public int BLFactoryAdd(TblFactory factory)
        {
            if (FieldCheck.checkBasicStringField(factory.factoryName, 1, 40)
                || FieldCheck.checkAddressField(factory.factoryAddress)
                || FieldCheck.checkPhoneField(factory.factoryTelephoneNumber)
                || FieldCheck.checkEmailField(factory.factoryEmail)
                || factory.factoryCountry<0
                || FieldCheck.checkBasicStringField(factory.factoryProductionCode,3,3)
                )
            {
                return -1;
            }

            using (var repository = new FactoryRepository())
            {
                return repository.DALFactoryAdd(factory);
            }
        }
        public int BLFactoryUpdate(TblFactory factory)
        {
            if (factory.factoryId<0
                ||FieldCheck.checkBasicStringField(factory.factoryName, 1, 40)
                || FieldCheck.checkAddressField(factory.factoryAddress)
                || FieldCheck.checkPhoneField(factory.factoryTelephoneNumber)
                || FieldCheck.checkEmailField(factory.factoryEmail)
                || factory.factoryCountry<0
                || FieldCheck.checkBasicStringField(factory.factoryProductionCode,3,3)
                )
            {
                return -1;
            }

            using (var repository = new FactoryRepository())
            {
                return repository.DALFactoryUpdate(factory);
            }
        }

        public int BLFactoryDelete(TblFactory factory)
        {
            if(factory.factoryId<0)
            {
                return -1;
            }
            using (var repository = new FactoryRepository())
            {
                return repository.DALFactoryDelete(factory);
            }
        }
    }
}
