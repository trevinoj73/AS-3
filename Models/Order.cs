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
    public int date {get;set;}
    public string name {get;set;}
    public string price {get;set;}

    public List<Customer> Customers {get;set;}
}
}