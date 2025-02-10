using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class TblCustomerRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public TblCustomerRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblCustomer> DALTblCustomerList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblCustomer.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the TblCustomer", e);
            }
        }

        public int DALTblCustomerAdd(TblCustomer customer)
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

        public int DALTblCustomerUpdate(TblCustomer customer)
        {
            try
            {
                TblCustomer existingTblCustomer = dBMarketAppEntitiesContext.TblCustomer.Find(customer.customerId);
                if (existingTblCustomer != null)
                {
                    existingTblCustomer.customerName = customer.customerName;
                    existingTblCustomer.customerSurname = customer.customerSurname;
                    existingTblCustomer.customerEmail = customer.customerEmail;
                    existingTblCustomer.customerTelephoneNumber = customer.customerTelephoneNumber;
                    existingTblCustomer.customerGender = customer.customerGender;
                    existingTblCustomer.customerAddress = customer.customerAddress;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingTblCustomer.customerId;
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

        public int DALTblCustomerDelete(TblCustomer customer)
        {
            try
            {
                TblCustomer existingTblCustomer = dBMarketAppEntitiesContext.TblCustomer.Find(customer.customerId);
                if (existingTblCustomer != null)
                {
                    dBMarketAppEntitiesContext.TblCustomer.Remove(existingTblCustomer);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingTblCustomer.customerId;
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
