using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PuntoVenta.Models;

namespace PuntoVenta.Context
{
    public class MyContext : DbContext
    {
        public MyContext() : base("AzureConnection")
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Client> Clients { get; set; }
        
    }

}