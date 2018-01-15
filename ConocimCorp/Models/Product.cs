using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ConocimCorp.Models
{
    public class Product
    {   [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descrip { get; set; }
        public string Status { get; set; }
    }
}