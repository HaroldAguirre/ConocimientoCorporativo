using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace ConocimCorp.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}