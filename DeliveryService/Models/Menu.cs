using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DeliveryService.Models
{
    public class Menu
    {
        public int ID { get; set; }

        [Required]
        [DisplayName("Option name")]
        public string OptionName { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string Description { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}