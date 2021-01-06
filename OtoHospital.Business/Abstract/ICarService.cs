using OtoHospital.Entities.Concrete;
using OtoHospital.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace OtoHospital.Business.Abstract
{
    public interface ICarService
    {
        List<CustomerIsCarsDto> GetCarList();
        List<Car> GetCarListByCustomerId(int customerId);
        Car AddCar(Car car);

    }
}
