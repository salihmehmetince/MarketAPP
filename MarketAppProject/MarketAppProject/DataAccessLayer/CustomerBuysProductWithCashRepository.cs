using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class CustomerBuysProductWithCashRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public CustomerBuysProductWithCashRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblCustomerBuysProductWithCash> DALCustomerBuysProductWithCashList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblCustomerBuysProductWithCash.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the CustomerBuysProductWithCash", e);
            }
        }

        public int DALCustomerBuysProductWithCashAdd(TblCustomerBuysProductWithCash customerBuysProductWithCash)
        {
            try
            {
                if (customerBuysProductWithCash != null)
                {
                    dBMarketAppEntitiesContext.TblCustomerBuysProductWithCash.Add(customerBuysProductWithCash);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return customerBuysProductWithCash.customerBuysProductWithCashId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the customerBuysProductWithCash", e);
            }
        }

        public int DALCustomerBuysProductWithCashUpdate(TblCustomerBuysProductWithCash customerBuysProductWithCash)
        {
            try
            {
                TblCustomerBuysProductWithCash existingCustomerBuysProductWithCash = dBMarketAppEntitiesContext.TblCustomerBuysProductWithCash.Find(customerBuysProductWithCash.customerBuysProductWithCashId);
                if (existingCustomerBuysProductWithCash != null)
                {
                    existingCustomerBuysProductWithCash.customerId = customerBuysProductWithCash.customerId;
                    existingCustomerBuysProductWithCash.marketId = customerBuysProductWithCash.marketId;
                    existingCustomerBuysProductWithCash.totalPrice = customerBuysProductWithCash.totalPrice;
                    existingCustomerBuysProductWithCash.saleDate = customerBuysProductWithCash.saleDate;
                    existingCustomerBuysProductWithCash.saleCurrency = customerBuysProductWithCash.saleCurrency;
                    existingCustomerBuysProductWithCash.customerCurrency = customerBuysProductWithCash.customerCurrency;
                    existingCustomerBuysProductWithCash.currencySaleMomentValue = customerBuysProductWithCash.currencySaleMomentValue;
                    existingCustomerBuysProductWithCash.customerPaidInCurrency = customerBuysProductWithCash.customerPaidInCurrency;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingCustomerBuysProductWithCash.customerBuysProductWithCashId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the customerBuysProductWithCash", e);
            }
        }

        public int DALCustomerBuysProductWithCashDelete(TblCustomerBuysProductWithCash customerBuysProductWithCash)
        {
            try
            {
                TblCustomerBuysProductWithCash existingCustomerBuysProductWithCash = dBMarketAppEntitiesContext.TblCustomerBuysProductWithCash.Find(customerBuysProductWithCash.customerBuysProductWithCashId);
                if (existingCustomerBuysProductWithCash != null)
                {
                    dBMarketAppEntitiesContext.TblCustomerBuysProductWithCash.Remove(existingCustomerBuysProductWithCash);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingCustomerBuysProductWithCash.customerBuysProductWithCashId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the customerBuysProductWithCash", e);
            }
        }

        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
