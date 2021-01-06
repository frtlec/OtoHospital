using OtoHospital.Business.Abstract;
using OtoHospital.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OtoHospital.WebUI.Controllers
{
    public class CustomersController : Controller
    {
        private ICustomerService _customerService;
        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet]
        public ActionResult Index()
        {
            List<Customer> result = _customerService.GetCustomers();
         
            return View(result);
        }
        [HttpGet]
        public ActionResult Customer(int id)
        {
            Customer result = _customerService.GetCustomerById(id);

            return View(result);
        }
        [HttpGet]
        public ActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCustomer(Customer customer)
        {
            if (customer==null)
            {
                return View();
            }
            customer.CustomerAddedDate = DateTime.Now;
            customer.CustomerUpdateDate = DateTime.Now;
            Customer result = _customerService.AddCustomer(customer);

            return View(result);
        }
        [HttpPost]
        public ActionResult UpdateCustomer(Customer customer)
        {
            Customer result = _customerService.UpdateCustomer(customer);

            return View(result);
        }
        [HttpPost]
        public ActionResult DeleteCustomer(Customer customer)
        {

            _customerService.DeleteCustomer(customer);

            return RedirectToAction("Index");
        }
    }
}