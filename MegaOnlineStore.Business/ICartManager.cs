using MegaOnlineStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaOnlineStore.Business
{
    public interface ICartManager
    {
        void AddToCart(Product cartItem);
        List<Product> GetAllCartItems();
        Product GetCartItem(int id);
        void DeleteCartItem(int id);
        double GetBillAmount();
        int GetCartItemsCount();


    }
}
