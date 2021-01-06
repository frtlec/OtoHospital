using OtoHospital.Business.Abstract;
using OtoHospital.DataAccessLayer.Abstract;
using OtoHospital.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace OtoHospital.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
           _customerDal = customerDal;
        }

        public Customer GetCustomerById(int id)
        {
            return _customerDal.Get(c => c.CustomerId == id);
        }

        public List<Customer> GetCustomers()
        {
            return _customerDal.GetList();
        }
        public Customer AddCustomer(Customer customer)
        {
            return _customerDal.Add(customer);
        }

        public void DeleteCustomer(Customer customer)
        {
            _customerDal.Delete(customer);
        }

        public Customer UpdateCustomer(Customer customer)
        {
            return _customerDal.Update(customer);
        }
    }
}
