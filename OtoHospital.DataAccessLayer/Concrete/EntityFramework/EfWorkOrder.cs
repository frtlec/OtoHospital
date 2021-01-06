using Core.DataAccess.EntityFramework;
using OtoHospital.DataAccessLayer.Abstract;
using OtoHospital.Entities.Concrete;
using OtoHospital.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OtoHospital.DataAccessLayer.Concrete.EntityFramework
{
    public class EfWorkOrder : EfEntityRepositoryBase<WorkOrder, OtoHospitalDBContext>, IWorkOrderDal
    {
        public List<CustomerIsWorkOrderDto> GetListByCustomerId(int customerId)
        {
            using (OtoHospitalDBContext context = new OtoHospitalDBContext())
            {
                var result = from workorder in context.WorkOrder
                             join car in context.Cars on workorder.CarId equals car.CarId
                             join cust in context.Customers on car.CustomerId equals cust.CustomerId
                             where cust.CustomerId == customerId
                             select new CustomerIsWorkOrderDto
                             {
                                 CustomerId = cust.CustomerId,
                                 CarId = car.CarId,
                                 WorkOrderCreationDate = workorder.WorkOrderCreationDate,
                                 WorkOrderFinishDate = workorder.WorkOrderFinishDate,
                                 WorkOrderStartDate = workorder.WorkOrderStartDate,
                                 WorkOrderDescription=workorder.WorkOrderDescription,
                                 WorkOrderId=workorder.WorkOrderId,
                                 CarBrand = car.CarBrand,
                                 CarModel = car.CarModel,
                                 CarModelYear = car.CarModelYear,
                                 CarPlaque = car.CarPlaque


                             };


                return result.ToList();

            }
        }
    }
}
