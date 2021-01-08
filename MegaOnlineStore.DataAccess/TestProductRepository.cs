using MegaOnlineStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaOnlineStore.DataAccess
{
    public class TestProductRepository : IProductRepository
    {
        public void AddProduct(Product newProduct)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<string> GetAllCatagory()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    ProductID = 1,Name = "product 1",Description = "description 1",Price = 100,Quantity = 10
                },
                new Product
                {
                    ProductID = 2,Name = "product 2",Description = "description 2",Price = 200,Quantity = 20
                },

                new Product
                {
                    ProductID = 2,Name = "product 2",Description = "description 2",Price = 200,Quantity = 20
                }
            };
        }

        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByName(string name)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product modifiedProduct)
        {
            throw new NotImplementedException();
        }
    }
}
