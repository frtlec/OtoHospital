using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OtoHospital.Entities.Dtos
{
    public class CustomerIsAppointmentsDto:IDtos
    {
        public int AppointmenId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int CarId { get; set; }
        public string AppointmentDescription { get; set; }
        public DateTime AppointmentCreationDate { get; set; }
        public DateTime AppointmentUpdateDate { get; set; }
        public int CustomerId { get; set; }
     
    
        public string CarPlaque { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public string CarModelYear { get; set; }
        public DateTime CarAddedDate { get; set; }
        public DateTime CarUpdateDate { get; set; }
    }
}
