using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AS_3.Models
{
    public class DelveryP
    {
         
        public int DeliverID { get; set; } // primary key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Phone {get; set; }
        public List<Order> Orders {get; set;} // Navigation property to Shipments
    }
}