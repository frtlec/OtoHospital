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
    public class WorkOrdersController : Controller
    {
       private IWorkOrderService _WorkOrderService;
        private ICustomerService _customerService;
        public WorkOrdersController(IWorkOrderService WorkOrderService, ICustomerService customerService = null)
        {
            _WorkOrderService = WorkOrderService;
            _customerService = customerService;
        }

        public ActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult CreateWorkOrder(WorkOrderViewModel WorkOrder)
        {
            
            WorkOrder.WorkOrderCreationDate = DateTime.Now;
            WorkOrder.WorkOrderUpdateDate = DateTime.Now;

            //add
            var model = new WorkOrder();
            model.WorkOrderCreationDate = WorkOrder.WorkOrderCreationDate;
            model.CarId = WorkOrder.CarId;
            model.WorkOrderStartDate = WorkOrder.WorkOrderStartDate;
            
            model.WorkOrderDescription = WorkOrder.WorkOrderDescription;
            model.WorkOrderUpdateDate = WorkOrder.WorkOrderUpdateDate;
            _WorkOrderService.AddWorkOrder(model);
          

            return RedirectToAction("GetListWorkOrderByCustomerId", new RouteValueDictionary(
                                 new { controller = "WorkOrders", action = "GetListWorkOrderByCustomerId", Id = WorkOrder.CustomerId }));
        }
        [HttpGet]
        public ActionResult GetListWorkOrderByCustomerId(int id)
        {
            List<CustomerIsWorkOrderDto> result = _WorkOrderService.GetWorkOrderByCustomerId(id);
            Customer customer = _customerService.GetCustomerById((int)id);
            return View(new Tuple<List<CustomerIsWorkOrderDto>, Customer>(result, customer));
        }
        [HttpGet]
        public ActionResult FinishWork(int id,int customerId)
        {
            WorkOrder item = _WorkOrderService.GetWorkOrderGetById(id);
            item.WorkOrderFinishDate = DateTime.Now;
            _WorkOrderService.UpdateWorkOrder(item);
            return RedirectToAction("GetListWorkOrderByCustomerId", new RouteValueDictionary(
                                  new { controller = "WorkOrders", action = "GetListWorkOrderByCustomerId", Id = customerId }));
        }
    }
}