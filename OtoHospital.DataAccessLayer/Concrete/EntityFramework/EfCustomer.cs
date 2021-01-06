using Core.DataAccess.EntityFramework;
using OtoHospital.DataAccessLayer.Abstract;
using OtoHospital.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace OtoHospital.DataAccessLayer.Concrete.EntityFramework
{
    public class EfCustomer:EfEntityRepositoryBase<Customer,OtoHospitalDBContext>, ICustomerDal
    {
    }
}
