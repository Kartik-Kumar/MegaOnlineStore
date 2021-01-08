using MegaOnlineStore.Entities;
using System;
using System.Data.Entity;
using System.Linq;

namespace MegaOnlineStore.DataAccess
{
    public class ProductContextDB : DbContext
    {
       
        public ProductContextDB()
            : base("name=ProductContextDB")
        {
        }

        public virtual DbSet<Product> Products { get; set; }
      
    }

   
}