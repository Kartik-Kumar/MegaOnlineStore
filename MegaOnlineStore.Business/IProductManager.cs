using MegaOnlineStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaOnlineStore.Business
{
    public interface IProductManager
    {
        List<Product> GetProduct();
        List<Product> GetProductByName(string name);
        List<string> GetAllCatagory();
        Product GetProductById(int id);
        void AddProduct(Product newProduct);
        void DeleteProduct(int id);
        void UpdateProduct(Product modifiedProduct);

    }
}
