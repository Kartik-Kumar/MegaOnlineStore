using MegaOnlineStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaOnlineStore.DataAccess
{
    public class EFProductsRepository : IProductRepository
    {
        public List<Product> GetAllProducts()
        {
            ProductContextDB db = new ProductContextDB();

            return db.Products.ToList();
        }

        public List<Product> GetProductsByName(string name)
        {
            
            ProductContextDB db = new ProductContextDB();
            var pList = (from p in db.Products
                        where p.Name.ToLower().Contains(name.ToLower()) || p.Catagory.ToLower().Contains(name.ToLower())
                        select p).ToList();
            return pList;
        }

        public List<string> GetAllCatagory()
        {
            ProductContextDB db = new ProductContextDB();

            List<string> li = (from c in db.Products
                               select c.Catagory).Distinct().ToList();
            return li;
        }

        public void AddProduct(Product newProduct)
        {
            ProductContextDB db = new ProductContextDB();
            db.Products.Add(newProduct);
            db.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            ProductContextDB db = new ProductContextDB();
            db.Products.Remove(db.Products.Find(id));
            db.SaveChanges();
        }

        public void UpdateProduct(Product modifiedProduct)
        {
            ProductContextDB db = new ProductContextDB();
            db.Entry<Product>(modifiedProduct).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public Product GetProductById(int id)
        {
            ProductContextDB db = new ProductContextDB();
            return db.Products.Find(id) as Product;
        }
    }
}
