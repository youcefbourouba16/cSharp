using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace first_web_app.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("first_web_app")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}