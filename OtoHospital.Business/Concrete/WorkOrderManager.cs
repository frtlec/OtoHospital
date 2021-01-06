using OtoHospital.Business.Abstract;
using OtoHospital.DataAccessLayer.Abstract;
using OtoHospital.Entities.Concrete;
using OtoHospital.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace OtoHospital.Business.Concrete
{
    public class WorkOrderManager : IWorkOrderService
    {
        private IWorkOrderDal _workOrderDal;
        public WorkOrderManager(IWorkOrderDal workOrderDal)
        {
            _workOrderDal = workOrderDal;
        }
      

        public WorkOrder GetWorkOrderByCarId(int carId)
        {
            return _workOrderDal.Get(w => w.CarId == carId);
        }

        public WorkOrder AddWorkOrder(WorkOrder workOrder)
        {
            return _workOrderDal.Add(workOrder);
        }
        public List<CustomerIsWorkOrderDto> GetWorkOrderByCustomerId(int customerId)
        {
            return _workOrderDal.GetListByCustomerId(customerId);
        }

        public WorkOrder UpdateWorkOrder(WorkOrder workOrder)
        {
            return _workOrderDal.Update(workOrder);
        }

        public WorkOrder GetWorkOrderGetById(int workId)
        {
            return _workOrderDal.Get(f=>f.WorkOrderId==workId);
        }
    }
}
