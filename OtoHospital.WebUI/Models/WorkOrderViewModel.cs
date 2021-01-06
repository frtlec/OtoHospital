using OtoHospital.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OtoHospital.WebUI.Models
{
    public class WorkOrderViewModel : WorkOrder
    {
        public int CustomerId { get; set; }
    }
}