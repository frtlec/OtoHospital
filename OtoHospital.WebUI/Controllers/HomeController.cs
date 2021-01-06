using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OtoHospital.Business.Abstract;

namespace OtoHospital.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private ICustomerService _customerService;
        public HomeController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        public ActionResult Index()
        {
            var list = _customerService.GetCustomers();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}