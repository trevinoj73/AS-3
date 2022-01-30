using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AS_3.Models
{
    public class Grocery
    {
        public int GroceryID { get; set; } // primary key
        public string GroceryName { get; set; }
        public string Price { get; set; }
        public List<Store> Stores { get; set; } // Navigation property to Stores
    }
}