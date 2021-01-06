using Core.DataAccess;
using OtoHospital.Entities.Concrete;
using OtoHospital.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace OtoHospital.DataAccessLayer.Abstract
{
    public interface IAppointmentDal : IEntityRepository<Appointment>
    {
        List<CustomerIsAppointmentsDto> GetListByCustomerId(int customerId);
    }
}
