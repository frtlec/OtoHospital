using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OtoHospital.Entities.Concrete
{
    public class Appointment:IEntity
    {
        [Key]
        public int AppointmenId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int CarId { get; set; }
        public string AppointmentDescription { get; set; }
        public DateTime AppointmentCreationDate { get; set; }
        public DateTime AppointmentUpdateDate { get; set; }
    }
}
