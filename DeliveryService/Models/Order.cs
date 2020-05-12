using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DeliveryService.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }       
        public int MenuID { get; set; }

        [Required]
        [DisplayName("Delivery date and time")]
        public DateTime DeliveryTime { get; set; }

        public Customer Customer { get; set; }
        public Menu Menu { get; set; }
    }
}