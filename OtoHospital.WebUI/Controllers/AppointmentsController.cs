using OtoHospital.Business.Abstract;
using OtoHospital.Entities.Concrete;
using OtoHospital.Entities.Dtos;
using OtoHospital.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OtoHospital.WebUI.Controllers
{
    public class AppointmentsController : Controller
    {
       private IAppointmentService _appointmentService;
        private ICustomerService _customerService;
        public AppointmentsController(IAppointmentService appointmentService, ICustomerService customerService = null)
        {
            _appointmentService = appointmentService;
            _customerService = customerService;
        }

        public ActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult CreateAppointment(AppointmentViewModel appointment)
        {
            
            appointment.AppointmentCreationDate = DateTime.Now;
            appointment.AppointmentUpdateDate = DateTime.Now;

            //add
            var model = new Appointment();
            model.AppointmentCreationDate = appointment.AppointmentCreationDate;
            model.CarId = appointment.CarId;
            model.AppointmentDate = appointment.AppointmentDate;
            model.AppointmentDescription = appointment.AppointmentDescription;
            model.AppointmentUpdateDate = appointment.AppointmentUpdateDate;
            _appointmentService.AddAppointment(model);
          

            return RedirectToAction("GetListAppointmentByCustomerId", new RouteValueDictionary(
                                 new { controller = "Appointments", action = "GetListAppointmentByCustomerId", Id = appointment.CustomerId }));
        }
        [HttpGet]
        public ActionResult GetListAppointmentByCustomerId(int id)
        {
            List<CustomerIsAppointmentsDto> result = _appointmentService.GetAppointmentByCustomerId(id);
            Customer customer = _customerService.GetCustomerById((int)id);
            return View(new Tuple<List<CustomerIsAppointmentsDto>, Customer>(result, customer));
        }
    }
}