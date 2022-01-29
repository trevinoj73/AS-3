using Microsoft.EntityFrameworkCore;


namespace  AS_3.Models 
{
    public class OrderContext : DbContext
    {
        public OrderContext (DbContextOptions<OrderContext> options)
            : base(options)
        {
        }

        public DbSet <Customer> Customer { get; set; }

        public DbSet<Order> Order {get;set;}
        
    }
}