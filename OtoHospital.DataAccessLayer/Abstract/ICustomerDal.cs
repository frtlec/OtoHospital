using Core.DataAccess;
using OtoHospital.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace OtoHospital.DataAccessLayer.Abstract
{
    public interface ICustomerDal : IEntityRepository<Customer>
    {
    }
}
