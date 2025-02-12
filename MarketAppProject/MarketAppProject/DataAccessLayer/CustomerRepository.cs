using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class CustomerRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public CustomerRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblCustomer> DALCustomerList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblCustomer.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the Customer", e);
            }
        }

        public int DALCustomerAdd(TblCustomer customer)
        {
            try
            {
                if (customer != null)
                {
                    dBMarketAppEntitiesContext.TblCustomer.Add(customer);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return customer.customerId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the customer", e);
            }
        }

        public int DALCustomerUpdate(TblCustomer customer)
        {
            try
            {
                TblCustomer existingCustomer = dBMarketAppEntitiesContext.TblCustomer.Find(customer.customerId);
                if (existingCustomer != null)
                {
                    existingCustomer.customerName = customer.customerName;
                    existingCustomer.customerSurname = customer.customerSurname;
                    existingCustomer.customerEmail = customer.customerEmail;
                    existingCustomer.customerTelephoneNumber = customer.customerTelephoneNumber;
                    existingCustomer.customerGender = customer.customerGender;
                    existingCustomer.customerAddress = customer.customerAddress;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingCustomer.customerId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the customer", e);
            }
        }

        public int DALCustomerDelete(TblCustomer customer)
        {
            try
            {
                TblCustomer existingCustomer = dBMarketAppEntitiesContext.TblCustomer.Find(customer.customerId);
                if (existingCustomer != null)
                {
                    dBMarketAppEntitiesContext.TblCustomer.Remove(existingCustomer);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingCustomer.customerId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the customer", e);
            }
        }

        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
