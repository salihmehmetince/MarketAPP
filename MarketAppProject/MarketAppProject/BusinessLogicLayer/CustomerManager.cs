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
    internal class CustomerManager
    {
        public List<TblCustomer> BLCustomerList()
        {
            using (var repository = new CustomerRepository())
            {
                return repository.DALCustomerList();
            }
        }

        public int BLCustomerAdd(TblCustomer customer)
        {
            if (string.IsNullOrWhiteSpace(customer.customerName)
                ||customer.customerName.Length<1
                ||customer.customerName.Length>40
                ||string.IsNullOrWhiteSpace(customer.customerSurname)
                ||customer.customerSurname.Length<1
                ||customer.customerSurname.Length>40
                ||FieldCheck.checkEmailField(customer.customerEmail)
                ||FieldCheck.checkPhoneField(customer.customerTelephoneNumber)
                ||FieldCheck.checkGenderField(customer.customerGender)
                ||FieldCheck.checkAddressField(customer.customerAddress)
                )
            {
                return -1;
            }

            using (var repository = new CustomerRepository())
            {
                return repository.DALCustomerAdd(customer);
            }
        }
        public int BLCustomerUpdate(TblCustomer customer)
        {
            if (customer.customerId<0
                ||string.IsNullOrWhiteSpace(customer.customerName)
                ||customer.customerName.Length<1
                ||customer.customerName.Length>40
                ||string.IsNullOrWhiteSpace(customer.customerSurname)
                ||customer.customerSurname.Length<1
                ||customer.customerSurname.Length>40
                ||FieldCheck.checkEmailField(customer.customerEmail)
                ||FieldCheck.checkPhoneField(customer.customerTelephoneNumber)
                ||FieldCheck.checkGenderField(customer.customerGender)
                ||FieldCheck.checkAddressField(customer.customerAddress)
                )
            {
                return -1;
            }

            using (var repository = new CustomerRepository())
            {
                return repository.DALCustomerUpdate(customer);
            }
        }

        public int BLCustomerDelete(TblCustomer customer)
        {
            using (var repository = new CustomerRepository())
            {
                return repository.DALCustomerDelete(customer);
            }
        }
    }
}
