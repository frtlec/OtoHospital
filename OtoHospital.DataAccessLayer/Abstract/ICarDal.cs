using Core.DataAccess;
using OtoHospital.Entities.Concrete;
using OtoHospital.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace OtoHospital.DataAccessLayer.Abstract
{
    public interface ICarDAL : IEntityRepository<Car>
    {
        List<CustomerIsCarsDto> GetCustomerIsCars(int customerId);
        List<CustomerIsCarsDto> GetList();
    }
}
