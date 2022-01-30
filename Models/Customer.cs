using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;



namespace AS_3.Models
{
      public class Customer
{
        public int CustID {get;set;}
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string Email { get; set; }
        public string Address {get; set;}
        public string City {get; set;}
        public string State {get; set;}
        public int zipCode {get; set;}
        public String phoneNumber {get; set;}
   public List<Order> Orders {get;set;}

}
}
