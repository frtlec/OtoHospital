using System;
using System.Collections.Generic;
using System.Text;

namespace OtoHospital.Entities.Dtos
{
    public class CustomerIsWorkOrderDto
    {
        public int WorkOrderId { get; set; }
        public int CarId { get; set; }
        public DateTime WorkOrderStartDate { get; set; }
        public DateTime? WorkOrderFinishDate { get; set; }
        public string WorkOrderDescription { get; set; }
        public DateTime WorkOrderCreationDate { get; set; }
        public DateTime WorkOrderUpdateDate { get; set; }
        public int CustomerId { get; set; }

        public string CarPlaque { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public string CarModelYear { get; set; }
        public DateTime CarAddedDate { get; set; }
        public DateTime CarUpdateDate { get; set; }
    }
}
