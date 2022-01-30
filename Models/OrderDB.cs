using System;
using Microsoft.EntityFrameworkCore;

namespace  AS_3.Models 
{
    public class OrderContext : DbContext
    {
        public OrderContext (DbContextOptions<OrderContext> options)
            : base(options)
        {
        }

        public DbSet <Customer> Customers { get; set; }
        public DbSet<DelveryP> DelveryPs{get;set;}
        public DbSet<Grocery> Groceries {get;set;}
        public DbSet<Store> Stores{get;set;}
        public DbSet<Order> Orders {get;set;}
        
    }
}