using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OtoHospital.Entities.Concrete
{
    public class Car:IEntity
    {
        [Key]
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public string CarPlaque { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public string CarModelYear { get; set; }
        public DateTime CarAddedDate { get; set; } 
        public DateTime CarUpdateDate { get; set; }
    }
}
