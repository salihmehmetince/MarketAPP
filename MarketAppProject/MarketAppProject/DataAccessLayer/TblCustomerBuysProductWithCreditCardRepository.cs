using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class TblCustomerBuysProductWithCreditCardRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public TblCustomerBuysProductWithCreditCardRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblCustomerBuysProductWithCreditCard> DALTblCustomerBuysProductWithCreditCardList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblCustomerBuysProductWithCreditCard.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the TblCustomerBuysProductWithCreditCard", e);
            }
        }

        public int DALTblCustomerBuysProductWithCreditCardAdd(TblCustomerBuysProductWithCreditCard customerBuysProductWithCreditCard)
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

        public int DALTblCustomerBuysProductWithCreditCardUpdate(TblCustomerBuysProductWithCreditCard customerBuysProductWithCreditCard)
        {
            try
            {
                TblCustomerBuysProductWithCreditCard existingTblCustomerBuysProductWithCreditCard = dBMarketAppEntitiesContext.TblCustomerBuysProductWithCreditCard.Find(customerBuysProductWithCreditCard.customerBuysProductWithCreditCardId);
                if (existingTblCustomerBuysProductWithCreditCard != null)
                {
                    existingTblCustomerBuysProductWithCreditCard.customerId = customerBuysProductWithCreditCard.customerId;
                    existingTblCustomerBuysProductWithCreditCard.marketId = customerBuysProductWithCreditCard.marketId;
                    existingTblCustomerBuysProductWithCreditCard.totalPrice = customerBuysProductWithCreditCard.totalPrice;
                    existingTblCustomerBuysProductWithCreditCard.saleDate = customerBuysProductWithCreditCard.saleDate;
                    existingTblCustomerBuysProductWithCreditCard.saleCurrency = customerBuysProductWithCreditCard.saleCurrency;
                    existingTblCustomerBuysProductWithCreditCard.cardNameFirstAndLastTwocharacters = customerBuysProductWithCreditCard.cardNameFirstAndLastTwocharacters;
                    existingTblCustomerBuysProductWithCreditCard.cardNumberLastFourDigidts = customerBuysProductWithCreditCard.cardNumberLastFourDigidts;
                    existingTblCustomerBuysProductWithCreditCard.cardLastUseYear = customerBuysProductWithCreditCard.cardLastUseYear;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingTblCustomerBuysProductWithCreditCard.customerBuysProductWithCreditCardId;
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

        public int DALTblCustomerBuysProductWithCreditCardDelete(TblCustomerBuysProductWithCreditCard customerBuysProductWithCreditCard)
        {
            try
            {
                TblCustomerBuysProductWithCreditCard existingTblCustomerBuysProductWithCreditCard = dBMarketAppEntitiesContext.TblCustomerBuysProductWithCreditCard.Find(customerBuysProductWithCreditCard.customerBuysProductWithCreditCardId);
                if (existingTblCustomerBuysProductWithCreditCard != null)
                {
                    dBMarketAppEntitiesContext.TblCustomerBuysProductWithCreditCard.Remove(existingTblCustomerBuysProductWithCreditCard);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingTblCustomerBuysProductWithCreditCard.customerBuysProductWithCreditCardId;
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
