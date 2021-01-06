using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using Ninject.Modules;
using OtoHospital.Business.Abstract;
using OtoHospital.Business.Concrete;
using OtoHospital.DataAccessLayer.Abstract;
using OtoHospital.DataAccessLayer.Concrete.EntityFramework;
namespace OtoHospital.Business.DependencyResolvers
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICustomerService>().To<CustomerManager>().InSingletonScope();
            Bind<ICustomerDal>().To<EfCustomer>().InSingletonScope();

            Bind<ICarService>().To<CarManager>().InSingletonScope();
            Bind<ICarDAL>().To<EfCar>().InSingletonScope();

            Bind<IAppointmentService>().To<AppointmentManager>().InSingletonScope();
            Bind<IAppointmentDal>().To<EfAppointment>().InSingletonScope();

            Bind<IWorkOrderService>().To<WorkOrderManager>().InSingletonScope();
            Bind<IWorkOrderDal>().To<EfWorkOrder>().InSingletonScope();


            //dbcontext binding
            Bind<DbContext>().To<OtoHospitalDBContext>();
        }
    }
}
