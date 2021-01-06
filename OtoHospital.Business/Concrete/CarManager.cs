using OtoHospital.Business.Abstract;
using OtoHospital.DataAccessLayer.Abstract;
using OtoHospital.Entities.Concrete;
using OtoHospital.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace OtoHospital.Business.Concrete
{
    
    public class CarManager : ICarService
    {
        private ICarDAL _carDal;
        public CarManager(ICarDAL carDal)
        {
            _carDal = carDal;
        }

        public Car AddCar(Car car)
        {
            return _carDal.Add(car);
        }

        public List<CustomerIsCarsDto> GetCarList()
        {
            return _carDal.GetList();
        }

        public List<Car> GetCarListByCustomerId(int customerId)
        {
            return _carDal.GetList(c=>c.CustomerId==customerId);
        }
    }
}
