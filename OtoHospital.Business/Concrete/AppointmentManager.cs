using OtoHospital.Business.Abstract;
using OtoHospital.DataAccessLayer.Abstract;
using OtoHospital.Entities.Concrete;
using OtoHospital.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace OtoHospital.Business.Concrete
{
    public class AppointmentManager : IAppointmentService
    {
        private IAppointmentDal _appointmentDal;
        public AppointmentManager(IAppointmentDal appointmentDal)
        {
            _appointmentDal = appointmentDal;
        }
        public Appointment AddAppointment(Appointment car)
        {
           return _appointmentDal.Add(car);
        }

        public Appointment GetAppointmentByCarId(int carId)
        {
            return _appointmentDal.Get(a => a.CarId == carId);
        }

        public List<CustomerIsAppointmentsDto> GetAppointmentByCustomerId(int customerId)
        {
            return _appointmentDal.GetListByCustomerId(customerId);
        }

        public Appointment GetAppointmentById(int appointmentId)
        {
            return _appointmentDal.Get(a => a.AppointmenId == appointmentId);
        }
    }
}
