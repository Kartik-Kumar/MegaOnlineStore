using MegaOnlineStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaOnlineStore.DataAccess;
namespace MegaOnlineStore.Business
{
    public class ProductManager : IProductManager
    {
        //use DIP to resolve Below problem
        //should not  have dependancr on concrete class
        IProductRepository repo = new EFProductsRepository();

        public void AddProduct(Product newProduct)
        {
            repo.AddProduct(newProduct);
        }

        public void DeleteProduct(int id)
        {
            repo.DeleteProduct(id);
        }

        public List<string> GetAllCatagory()
        {
            return repo.GetAllCatagory();
        }

        public List<Product> GetProduct()
        {
            return repo.GetAllProducts();
        }

        public Product GetProductById(int id)
        {
            return repo.GetProductById(id);
        }

        public List<Product> GetProductByName(string name)
        {
            return repo.GetProductsByName(name);
        }

        public void UpdateProduct(Product modifiedProduct)
        {
            repo.UpdateProduct(modifiedProduct);
        }
    }
}
