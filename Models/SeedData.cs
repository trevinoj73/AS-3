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
               
                if (context.Order.Any())
                {
                    return;   
                }

                context.Order.AddRange(
                    new Order
                    {
                        name = "12in pizza",
                         price= "12.2",
                        date = 12-12-21,
                
                    }

              

                );
                context.SaveChanges();
            }
        }
    }
}