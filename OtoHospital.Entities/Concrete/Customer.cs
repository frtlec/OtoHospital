using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OtoHospital.Entities.Concrete
{
    public class Customer:IEntity
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerFullName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public DateTime CustomerAddedDate { get; set; }
        public DateTime CustomerUpdateDate { get; set; }
    }
}
