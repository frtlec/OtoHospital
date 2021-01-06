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
    public class EfAppointment : EfEntityRepositoryBase<Appointment, OtoHospitalDBContext>, IAppointmentDal
    {
        public List<CustomerIsAppointmentsDto> GetListByCustomerId(int customerId)
        {
            using (OtoHospitalDBContext context = new OtoHospitalDBContext())
            {
                var result = from apoint in context.Appointments
                             join car in context.Cars on apoint.CarId equals car.CarId
                             join cust in context.Customers on car.CustomerId equals cust.CustomerId
                             where cust.CustomerId==customerId
                             select new CustomerIsAppointmentsDto
                             {
                                 CustomerId = cust.CustomerId,
                                 CarId =car.CarId,
                                 AppointmentCreationDate=apoint.AppointmentCreationDate,
                                 AppointmenId=apoint.AppointmenId,
                                 AppointmentDate=apoint.AppointmentDate,
                                 AppointmentDescription=apoint.AppointmentDescription,
                                 AppointmentUpdateDate=apoint.AppointmentUpdateDate,
                                 CarBrand=car.CarBrand,
                                 CarModel=car.CarModel,
                                 CarModelYear=car.CarModelYear,
                                 CarPlaque=car.CarPlaque
                                 

                             };


                return result.ToList();

            }
        }
    }
}
