using OtoHospital.Business.Abstract;
using OtoHospital.Entities.Concrete;
using OtoHospital.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OtoHospital.WebUI.Controllers
{
    public class CarsController : Controller
    {
        private ICarService _carService;
        private ICustomerService _customerService;
        private IAppointmentService _appointmentService;
        public CarsController(ICarService carService, ICustomerService customerService, IAppointmentService appointmentService = null)
        {
            _carService = carService;
            _customerService = customerService;
            _appointmentService = appointmentService;
        }
     
        [HttpGet]
        public ActionResult CustomerIsCars(int? id)
        {
            if (id==null)
            {
                return RedirectToAction("Index", "Customers");
            }
            List<Car> result = _carService.GetCarListByCustomerId((int)id);
            Customer customer = _customerService.GetCustomerById((int)id);
            List<CustomerIsAppointmentsDto> customerIsAppointmentsDto = _appointmentService.GetAppointmentByCustomerId((int)id); 
            return View(new Tuple<List<Car>,Customer,List<CustomerIsAppointmentsDto>>(result, customer, customerIsAppointmentsDto));
        }
        [HttpPost]
        public ActionResult AddCustomerToCar(Car car)
        {
            if (car==null)
            {
                return RedirectToAction("Index","Customers");
            }
            car.CarAddedDate = DateTime.Now;
            car.CarUpdateDate = DateTime.Now;
            _carService.AddCar(car);
            return RedirectToAction("CustomerIsCars", new RouteValueDictionary(
                                 new { controller = "Cars", action = "CustomerIsCars", Id = car.CustomerId }));
        }
    }
}