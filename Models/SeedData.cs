using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Collections.Generic;


namespace AS_3.Models 
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new OrderContext(
                serviceProvider.GetRequiredService<DbContextOptions<OrderContext>>()))
            {
               
                if (context.Customers.Any())
                {
                    return;   
                }

                context.Customers.AddRange(
                    new Customer
                    {
                        firstName = "Javier",
                         lastName= "Trevino",
                        Email = "jtrevino1@buffs.wtamu.edu",
                        Address="1300 Nowhere St",
                        City="Amarillo",
                        State="TX",
                        zipCode=12345,
                        phoneNumber="8062125000"
                
                    },
                      new Customer
                    {
                        firstName = "Rees",
                         lastName= "Byrd",
                        Email = "",
                        Address="",
                        City="",
                        State="",
                        zipCode=12345,
                        phoneNumber=""
                
                    },
                      new Customer
                    {
                        firstName = "Ashley",
                         lastName= "Gilbert",
                        Email = "",
                        Address="",
                        City="",
                        State="",
                        phoneNumber="",
                        zipCode=1234,
                
                    }

              

                );
                context.SaveChanges();
            }
        }
    }
}