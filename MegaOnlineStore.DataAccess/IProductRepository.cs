using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaOnlineStore.Entities;
namespace MegaOnlineStore.DataAccess
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        List<Product> GetProductsByName(string name);
        List<string> GetAllCatagory();
        Product GetProductById(int id);
        void AddProduct(Product newProduct);
        void DeleteProduct(int id);
        void UpdateProduct(Product modifiedProduct);
    }
}
