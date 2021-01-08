using MegaOnlineStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaOnlineStore.Business
{

    public class CartManager : ICartManager
    {
        List<Product> Cart = new List<Product>();
        public void AddToCart(Product cartItem)
        {

            var item = Cart.FirstOrDefault(i => i.ProductID == cartItem.ProductID);
            if (item == null)
                Cart.Add(cartItem);
            else
            {
                item.Quantity += cartItem.Quantity;
            }
        }

        public void DeleteCartItem(int id)
        {
            Cart.Remove(Cart.FirstOrDefault(i => i.ProductID == id));
        }

        public List<Product> GetAllCartItems()
        {
            return Cart;
        }

        public double GetBillAmount()
        {
            return Cart.Sum(i => i.Quantity * i.Price);
        }

        public Product GetCartItem(int id)
        {
            return Cart.FirstOrDefault(i => i.ProductID == id);
        }

        public int GetCartItemsCount()
        {
            return Cart.Count;
        }
    }
}
