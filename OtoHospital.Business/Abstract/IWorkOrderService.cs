using OtoHospital.Entities.Concrete;
using OtoHospital.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace OtoHospital.Business.Abstract
{
    public interface IWorkOrderService
    {
        WorkOrder GetWorkOrderByCarId(int carId);
        WorkOrder AddWorkOrder(WorkOrder workOrder);
        WorkOrder UpdateWorkOrder(WorkOrder workOrder);
        WorkOrder GetWorkOrderGetById(int workId);
        List<CustomerIsWorkOrderDto> GetWorkOrderByCustomerId(int customerId);
    }
}
