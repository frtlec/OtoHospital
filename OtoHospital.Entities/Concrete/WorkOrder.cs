using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OtoHospital.Entities.Concrete
{
     public class WorkOrder:IEntity
    {
        [Key]
        public int WorkOrderId { get; set; }
        public int CarId { get; set; }
        public DateTime WorkOrderStartDate { get; set; }
        public DateTime? WorkOrderFinishDate { get; set; }
        public string WorkOrderDescription { get; set; }
        public DateTime WorkOrderCreationDate { get; set; }
        public DateTime WorkOrderUpdateDate { get; set; }
    }
}
