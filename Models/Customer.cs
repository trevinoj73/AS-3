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

    [Required]
    public string address {get;set;}
      [Required]
    public string city {get;set;}
      [Required]
    public string state {get;set;}
      [Required]
    public int zipCode {get;set;}
      [Required]
    public string eMail {get;set;}
      [Required]
    public int phoneNumber{get;set;}
    public Order Order {get;set;}

}
}
