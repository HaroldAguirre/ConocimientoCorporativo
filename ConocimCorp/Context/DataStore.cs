using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ConocimCorp.Models;

namespace ConocimCorp.Context
{
    public class DataStore: DbContext
    {
      public DbSet<Product> Products { get; set; } 
    }
}