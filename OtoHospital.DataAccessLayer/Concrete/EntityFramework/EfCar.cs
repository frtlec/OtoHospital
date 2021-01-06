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
    public class EfCar : EfEntityRepositoryBase<Car, OtoHospitalDBContext>, ICarDAL
    {
        public List<CustomerIsCarsDto> GetCustomerIsCars(int customerId)
        {
            using (OtoHospitalDBContext context = new OtoHospitalDBContext())
            {
                var result = from car in context.Cars
                             join cust in context.Customers
                             on car.CustomerId equals cust.CustomerId
                             where cust.CustomerId==customerId
                             select new CustomerIsCarsDto
                             {
                                  CustomerId=cust.CustomerId,
                                  CarId=car.CarId,
                                  CarBrand=car.CarBrand,
                                  CarModel=car.CarModel,
                                  CarModelYear=car.CarModelYear,
                                  CustomerFullName=cust.CustomerFullName,
                                  CustomerPhoneNumber=cust.CustomerPhoneNumber,
                                  CustomerEmail=cust.CustomerEmail,
                                  CarPlaque=car.CarPlaque,
                                  CarAddedDate=car.CarAddedDate,
                                  CarUpdateDate=car.CarUpdateDate

                             };


                return result.ToList();

            }
        }
        public List<CustomerIsCarsDto> GetList()
        {
            using (OtoHospitalDBContext context = new OtoHospitalDBContext())
            {
                var result = from car in context.Cars
                             join cust in context.Customers
                             on car.CustomerId equals cust.CustomerId
                             select new CustomerIsCarsDto
                             {
                                 CustomerId = cust.CustomerId,
                                 CarId = car.CarId,
                                 CarBrand = car.CarBrand,
                                 CarModel = car.CarModel,
                                 CarModelYear = car.CarModelYear,
                                 CustomerFullName = cust.CustomerFullName,
                                 CustomerPhoneNumber = cust.CustomerPhoneNumber,
                                 CustomerEmail = cust.CustomerEmail,
                                 CarPlaque = car.CarPlaque,
                                 CarAddedDate = car.CarAddedDate,
                                 CarUpdateDate = car.CarUpdateDate

                             };


                return result.ToList();

            }
        }

    }
}
