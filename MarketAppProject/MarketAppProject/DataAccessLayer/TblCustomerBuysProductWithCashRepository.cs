using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class TblCustomerBuysProductWithCashRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public TblCustomerBuysProductWithCashRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblCustomerBuysProductWithCash> DALTblCustomerBuysProductWithCashList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblCustomerBuysProductWithCash.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the TblCustomerBuysProductWithCash", e);
            }
        }

        public int DALTblCustomerBuysProductWithCashAdd(TblCustomerBuysProductWithCash customerBuysProductWithCash)
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

        public int DALTblCustomerBuysProductWithCashUpdate(TblCustomerBuysProductWithCash customerBuysProductWithCash)
        {
            try
            {
                TblCustomerBuysProductWithCash existingTblCustomerBuysProductWithCash = dBMarketAppEntitiesContext.TblCustomerBuysProductWithCash.Find(customerBuysProductWithCash.customerBuysProductWithCashId);
                if (existingTblCustomerBuysProductWithCash != null)
                {
                    existingTblCustomerBuysProductWithCash.customerId = customerBuysProductWithCash.customerId;
                    existingTblCustomerBuysProductWithCash.marketId = customerBuysProductWithCash.marketId;
                    existingTblCustomerBuysProductWithCash.totalPrice = customerBuysProductWithCash.totalPrice;
                    existingTblCustomerBuysProductWithCash.saleDate = customerBuysProductWithCash.saleDate;
                    existingTblCustomerBuysProductWithCash.saleCurrency = customerBuysProductWithCash.saleCurrency;
                    existingTblCustomerBuysProductWithCash.customerCurrency = customerBuysProductWithCash.customerCurrency;
                    existingTblCustomerBuysProductWithCash.currencySaleMomentValue = customerBuysProductWithCash.currencySaleMomentValue;
                    existingTblCustomerBuysProductWithCash.customerPaidInCurrency = customerBuysProductWithCash.customerPaidInCurrency;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingTblCustomerBuysProductWithCash.customerBuysProductWithCashId;
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

        public int DALTblCustomerBuysProductWithCashDelete(TblCustomerBuysProductWithCash customerBuysProductWithCash)
        {
            try
            {
                TblCustomerBuysProductWithCash existingTblCustomerBuysProductWithCash = dBMarketAppEntitiesContext.TblCustomerBuysProductWithCash.Find(customerBuysProductWithCash.customerBuysProductWithCashId);
                if (existingTblCustomerBuysProductWithCash != null)
                {
                    dBMarketAppEntitiesContext.TblCustomerBuysProductWithCash.Remove(existingTblCustomerBuysProductWithCash);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingTblCustomerBuysProductWithCash.customerBuysProductWithCashId;
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
