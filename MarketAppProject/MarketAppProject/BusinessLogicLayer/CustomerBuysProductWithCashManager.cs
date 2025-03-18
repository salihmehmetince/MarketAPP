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
    internal class CustomerBuysProductWithCashManager
    {
        public List<TblCustomerBuysProductWithCash> BLCustomerBuysProductWithCashList()
        {
            using (var repository = new CustomerBuysProductWithCashRepository())
            {
                return repository.DALCustomerBuysProductWithCashList();
            }
        }

        public int BLCustomerBuysProductWithCashLAdd(TblCustomerBuysProductWithCash customerBuysProductWithCash)
        {
            if (customerBuysProductWithCash.customerId<0
                ||customerBuysProductWithCash.marketId<0
                ||customerBuysProductWithCash.totalPrice<0
                ||!FieldCheck.checkDateTimeField(customerBuysProductWithCash.saleDate)
                ||customerBuysProductWithCash.saleCurrency<0
                ||customerBuysProductWithCash.customerCurrency<0
                )
            {
                return -1;
            }
            else
            {
                if(customerBuysProductWithCash.currencySaleMomentValue.HasValue)
                {
                    if(customerBuysProductWithCash.currencySaleMomentValue<0)
                    {
                        return -1;
                    }
                }
                if(customerBuysProductWithCash.customerPaidInCurrency.HasValue)
                {
                    if(customerBuysProductWithCash.customerPaidInCurrency < 0)
                    {
                        return -1;
                    }
                }
            }

            using (var repository = new CustomerBuysProductWithCashRepository())
            {
                return repository.DALCustomerBuysProductWithCashAdd(customerBuysProductWithCash);
            }
        }
        public int BLCustomerBuysProductWithCashLUpdate(TblCustomerBuysProductWithCash customerBuysProductWithCash)
        {
            if (customerBuysProductWithCash.customerBuysProductWithCashId < 0
                ||customerBuysProductWithCash.customerId<0
                ||customerBuysProductWithCash.marketId<0
                ||customerBuysProductWithCash.totalPrice<0
                ||!FieldCheck.checkDateTimeField(customerBuysProductWithCash.saleDate)
                ||customerBuysProductWithCash.saleCurrency<0
                ||customerBuysProductWithCash.customerCurrency<0
                )
            {
                return -1;
            }
            else
            {
                if (customerBuysProductWithCash.currencySaleMomentValue.HasValue)
                {
                    if (customerBuysProductWithCash.currencySaleMomentValue < 0)
                    {
                        return -1;
                    }
                }
                if (customerBuysProductWithCash.customerPaidInCurrency.HasValue)
                {
                    if (customerBuysProductWithCash.customerPaidInCurrency < 0)
                    {
                        return -1;
                    }
                }
            }

            using (var repository = new CustomerBuysProductWithCashRepository())
            {
                return repository.DALCustomerBuysProductWithCashUpdate(customerBuysProductWithCash);
            }
        }

        public int BLCustomerBuysProductWithCashDelete(TblCustomerBuysProductWithCash customerBuysProductWithCash)
        {
            if (customerBuysProductWithCash.customerBuysProductWithCashId < 0)
            {
                return -1;
            }
            using (var repository = new CustomerBuysProductWithCashRepository())
            {
                return repository.DALCustomerBuysProductWithCashDelete(customerBuysProductWithCash);
            }
        }

    }

}
