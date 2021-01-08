namespace MegaOnlineStore.DataAccess.Migrations
{
    using MegaOnlineStore.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MegaOnlineStore.DataAccess.ProductContextDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MegaOnlineStore.DataAccess.ProductContextDB context)
        {
            context.Products.AddOrUpdate(
                 new Product { ProductID = 1, Name = "Table d", Description = "Table foldable and have pencil stand in  it", Price = 500, Quantity = 22, Catagory= "House hold" },
                 new Product { ProductID = 2, Name = "Chair confo", Description = "Chair have four wheel called rolling chair", Price = 4500, Quantity = 4, Catagory = "House hold" },
                 new Product { ProductID = 3, Name = "headphone 360", Description = "dust resistance and noice cancellation proff", Price = 3900, Quantity = 5, Catagory = "electronic" },
                 new Product { ProductID = 4, Name = "dell laptop", Description = "A 500ssd hd and 8gb ram ", Price = 89999, Quantity = 14, Catagory = "Electronics" }
             );
        }
    }
}
