using OtoHospital.Entities.Concrete;
using OtoHospital.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace OtoHospital.Business.Abstract
{
    public interface IAppointmentService
    {

        List<CustomerIsAppointmentsDto> GetAppointmentByCustomerId(int customerId);
        Appointment GetAppointmentById(int appointmentId);
        Appointment GetAppointmentByCarId(int carId);
        Appointment AddAppointment(Appointment appointment);
    }
}
