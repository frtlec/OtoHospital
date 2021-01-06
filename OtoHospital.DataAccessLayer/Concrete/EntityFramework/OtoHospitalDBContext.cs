using OtoHospital.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace OtoHospital.DataAccessLayer.Concrete.EntityFramework
{
    public class OtoHospitalDBContext:DbContext
    {
        public OtoHospitalDBContext()
            :base("Data Source=DESKTOP-934O58E\\SQLEXPRESS;Initial Catalog=OtoHospital;" +
                 "Integrated Security=True;" +
                 "TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
            Database.SetInitializer<OtoHospitalDBContext>(null);

        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<WorkOrder> WorkOrder { get; set; }

    }
}
