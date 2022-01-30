using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;



namespace AS_3.Models
{
    
    public class Order

{
        public int orderID{get;set;} 
        public DateTime orderDate { get; set; } = DateTime.Now;
        public int DeliverID {get; set;}
        public DelveryP DelveryP {get; set;}
    
}
}