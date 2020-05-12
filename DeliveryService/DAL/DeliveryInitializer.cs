using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using DeliveryService.Models;

namespace DeliveryService.DAL
{
    public class DeliveryInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<DeliveryContext>
    {
        protected override void Seed(DeliveryContext context)
        {
            var customers = new List<Customer>
            {
                new Customer{FirstName = "Carson Alexander", Phone = "(223) 229-9226", Adress = "152 Newcastle St.", Allergies = "ginger" },
                new Customer{FirstName = "Meredith Alonso", Phone = "(312) 834-0177", Adress = "9051 Sutor Ave.", Allergies = "soy" },
                new Customer{FirstName = "Arturo Anand", Phone = "(889) 796-8408", Adress = "25 Brickyard Street", Allergies = "milk" },
                new Customer{FirstName = "Gytis Barzdukas", Phone = "(654) 606-1689", Adress = "7745 Summit Street", Allergies = "lactose" },
                new Customer{FirstName = "Yan Li", Phone = "(360) 588-5359", Adress = "668 Woodsman Dr.", Allergies = "peanut" },
            };

            customers.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();

            var menus = new List<Menu>
            {
                new Menu{OptionName ="Option 1", Price = 8, Description = "Peas (Onions and lentils fried together); canned food, salad; fruit salad"},
                new Menu{OptionName ="Option 2", Price = 10, Description = "Lentil Soup; beef bhuna, bread, salad; fruit salad "},
                new Menu{OptionName ="Option 3", Price = 8, Description = "Rice with peas; salmon soup, bread, salad; halva "},
                new Menu{OptionName ="Option 4", Price = 10, Description = "Rice with peas; bovine birani, salad; halva "},
                new Menu{OptionName ="Option 5", Price = 8, Description = "Chop (Fried potato steak); chicken tikka masala, rice, salad, halva"},
                new Menu{OptionName ="Option 6", Price = 10, Description = "Chop (Fried potato steak); salmon potato soup; salad; halva "}
            };

            menus.ForEach(s => context.Menu.Add(s));
            context.SaveChanges();
        }
    }
}