using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DeliveryService.Models
{
    public class Customer
    {
        public int ID { get; set; }

        [Required]
        [DisplayName("Customer name")]
        [StringLength(50)]
        public string FirstName { get; set; }

        //public string LastName { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }

        [Required]        
        public string Adress { get; set; }

        [StringLength(50)]
        public string Allergies { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}