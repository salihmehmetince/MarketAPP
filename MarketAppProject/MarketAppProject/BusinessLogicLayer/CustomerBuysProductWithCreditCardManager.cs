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
    internal class CustomerBuysProductWithCreditCardManager
    {
        public List<TblCustomerBuysProductWithCreditCard> BLCustomerBuysProductWithCreditCardList()
        {
            using (var repository = new CustomerBuysProductWithCreditCardRepository())
            {
                return repository.DALCustomerBuysProductWithCreditCardList();
            }
        }

        public int BLCustomerBuysProductWithCreditCardAdd(TblCustomerBuysProductWithCreditCard customerBuysProductWithCreditCard)
        {
            if (customerBuysProductWithCreditCard.customerId<0
                ||customerBuysProductWithCreditCard.marketId<0
                ||customerBuysProductWithCreditCard.totalPrice<0
                ||FieldCheck.checkDateTimeField(customerBuysProductWithCreditCard.saleDate)
                ||customerBuysProductWithCreditCard.saleCurrency<0
                ||string.IsNullOrWhiteSpace(customerBuysProductWithCreditCard.cardNameFirstAndLastTwocharacters)
                ||customerBuysProductWithCreditCard.cardNameFirstAndLastTwocharacters.Length<3
                ||string.IsNullOrWhiteSpace(customerBuysProductWithCreditCard.cardNumberLastFourDigidts)
                ||customerBuysProductWithCreditCard.cardNumberLastFourDigidts.Length!=4
                ||customerBuysProductWithCreditCard.cardLastUseYear<2000
                )
            {
                return -1;
            }

            using (var repository = new CustomerBuysProductWithCreditCardRepository())
            {
                return repository.DALCustomerBuysProductWithCreditCardAdd(customerBuysProductWithCreditCard);
            }
        }
        public int BLCustomerBuysProductWithCreditCardUpdate(TblCustomerBuysProductWithCreditCard customerBuysProductWithCreditCard)
        {
            if (customerBuysProductWithCreditCard.customerBuysProductWithCreditCardId<0
                ||customerBuysProductWithCreditCard.customerId<0
                ||customerBuysProductWithCreditCard.marketId<0
                ||customerBuysProductWithCreditCard.totalPrice<0
                ||FieldCheck.checkDateTimeField(customerBuysProductWithCreditCard.saleDate)
                ||customerBuysProductWithCreditCard.saleCurrency<0
                ||string.IsNullOrWhiteSpace(customerBuysProductWithCreditCard.cardNameFirstAndLastTwocharacters)
                ||customerBuysProductWithCreditCard.cardNameFirstAndLastTwocharacters.Length<3
                ||string.IsNullOrWhiteSpace(customerBuysProductWithCreditCard.cardNumberLastFourDigidts)
                ||customerBuysProductWithCreditCard.cardNumberLastFourDigidts.Length!=4
                ||customerBuysProductWithCreditCard.cardLastUseYear<2000
                )
            {
                return -1;
            }

            using (var repository = new CustomerBuysProductWithCreditCardRepository())
            {
                return repository.DALCustomerBuysProductWithCreditCardUpdate(customerBuysProductWithCreditCard);
            }
        }

        public int BLCustomerBuysProductWithCreditCardDelete(TblCustomerBuysProductWithCreditCard customerBuysProductWithCreditCard)
        {
            using (var repository = new CustomerBuysProductWithCreditCardRepository())
            {
                return repository.DALCustomerBuysProductWithCreditCardDelete(customerBuysProductWithCreditCard);
            }
        }
    }
}
