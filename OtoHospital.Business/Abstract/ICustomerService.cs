
using OtoHospital.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace OtoHospital.Business.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers();
        Customer GetCustomerById(int id);
        Customer AddCustomer(Customer customer);
        Customer UpdateCustomer(Customer customer);
        void DeleteCustomer(Customer customer);

    }
}
