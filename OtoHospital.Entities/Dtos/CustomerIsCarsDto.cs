using Core.Entities;
using OtoHospital.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace OtoHospital.Entities.Dtos
{
    public class CustomerIsCarsDto:IDtos
    {
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public string CarPlaque { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public string CarModelYear { get; set; }
        public DateTime CarAddedDate { get; set; }
        public DateTime CarUpdateDate { get; set; }
        public string CustomerFullName { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerEmail { get; set; }
    }
}
