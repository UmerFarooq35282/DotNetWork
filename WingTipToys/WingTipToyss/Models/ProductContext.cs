using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WingTipToyss.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("WingTipToyss")
        {
        }

        public DbSet<Product> Products { get; set;}
        public DbSet<Category> Categories { get; set;}
    }
}