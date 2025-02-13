using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class CustomerBuysProductWithCreditCardRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public CustomerBuysProductWithCreditCardRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblCustomerBuysProductWithCreditCard> DALCustomerBuysProductWithCreditCardList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblCustomerBuysProductWithCreditCard.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the CustomerBuysProductWithCreditCard", e);
            }
        }

        public int DALCustomerBuysProductWithCreditCardAdd(TblCustomerBuysProductWithCreditCard customerBuysProductWithCreditCard)
        {
            try
            {
                if (customerBuysProductWithCreditCard != null)
                {
                    dBMarketAppEntitiesContext.TblCustomerBuysProductWithCreditCard.Add(customerBuysProductWithCreditCard);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return customerBuysProductWithCreditCard.customerBuysProductWithCreditCardId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the customerBuysProductWithCreditCard", e);
            }
        }

        public int DALCustomerBuysProductWithCreditCardUpdate(TblCustomerBuysProductWithCreditCard customerBuysProductWithCreditCard)
        {
            try
            {
                TblCustomerBuysProductWithCreditCard existingCustomerBuysProductWithCreditCard = dBMarketAppEntitiesContext.TblCustomerBuysProductWithCreditCard.Find(customerBuysProductWithCreditCard.customerBuysProductWithCreditCardId);
                if (existingCustomerBuysProductWithCreditCard != null)
                {
                    existingCustomerBuysProductWithCreditCard.customerId = customerBuysProductWithCreditCard.customerId;
                    existingCustomerBuysProductWithCreditCard.marketId = customerBuysProductWithCreditCard.marketId;
                    existingCustomerBuysProductWithCreditCard.totalPrice = customerBuysProductWithCreditCard.totalPrice;
                    existingCustomerBuysProductWithCreditCard.saleDate = customerBuysProductWithCreditCard.saleDate;
                    existingCustomerBuysProductWithCreditCard.saleCurrency = customerBuysProductWithCreditCard.saleCurrency;
                    existingCustomerBuysProductWithCreditCard.cardNameFirstAndLastTwocharacters = customerBuysProductWithCreditCard.cardNameFirstAndLastTwocharacters;
                    existingCustomerBuysProductWithCreditCard.cardNumberLastFourDigidts = customerBuysProductWithCreditCard.cardNumberLastFourDigidts;
                    existingCustomerBuysProductWithCreditCard.cardLastUseYear = customerBuysProductWithCreditCard.cardLastUseYear;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingCustomerBuysProductWithCreditCard.customerBuysProductWithCreditCardId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the customerBuysProductWithCreditCard", e);
            }
        }

        public int DALCustomerBuysProductWithCreditCardDelete(TblCustomerBuysProductWithCreditCard customerBuysProductWithCreditCard)
        {
            try
            {
                TblCustomerBuysProductWithCreditCard existingCustomerBuysProductWithCreditCard = dBMarketAppEntitiesContext.TblCustomerBuysProductWithCreditCard.Find(customerBuysProductWithCreditCard.customerBuysProductWithCreditCardId);
                if (existingCustomerBuysProductWithCreditCard != null)
                {
                    dBMarketAppEntitiesContext.TblCustomerBuysProductWithCreditCard.Remove(existingCustomerBuysProductWithCreditCard);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingCustomerBuysProductWithCreditCard.customerBuysProductWithCreditCardId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the customerBuysProductWithCreditCard", e);
            }
        }

        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
