using MegaOnlineStore.Business;
using MegaOnlineStore.Entities;
using MegaOnlineStore.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MegaOnlineStore.Web.Controllers
{
    public class ShoppingController : Controller
    {
       
        ICartManager cartManager;
        // GET: Shopping
        public ActionResult Add(Product newItem)
        {
            cartManager = GetcartManager();
            cartManager.AddToCart(newItem);
            var cartItems = cartManager.GetAllCartItems();
            List<CartViewModel> cardViewModel= (from p in cartItems
                                      select new CartViewModel
                                   {
                                           ProductID = p.ProductID,
                                           Name = p.Name,
                                           Quantity = p.Quantity,
                                           Price = p.Price,
                                           Description = p.Description,
                                           Catagory = p.Catagory,
                                           Amount = p.Price * p.Quantity
                                   }).ToList();
            var finalCartView = new FinalCartModel();
            finalCartView.cartViewModel = cardViewModel;
            finalCartView.TotalAmount = cartManager.GetBillAmount();
            finalCartView.TotalItem = cartManager.GetCartItemsCount();
            return View("MyOrder", finalCartView);

        }

        private ICartManager GetcartManager()
        {
            if (Session["cart"] == null)
            {
                cartManager = new CartManager();
                Session["cart"] = cartManager;
            }
            else
            {
                cartManager = (ICartManager)Session["cart"];
            }
            return cartManager;

        }

        public ActionResult Delete(int id)
        {
            cartManager = GetcartManager();
            cartManager.DeleteCartItem(id);
            Session["cart"] = cartManager;
            /*            return RedirectToAction("Cart", "Shopping");
            */
            var cartItems = cartManager.GetAllCartItems();
            List<CartViewModel> cardViewModel = (from p in cartItems
                                                 select new CartViewModel
                                                 {
                                                     ProductID = p.ProductID,
                                                     Name = p.Name,
                                                     Quantity = p.Quantity,
                                                     Price = p.Price,
                                                     Description = p.Description,
                                                     Catagory = p.Catagory,
                                                     Amount = p.Price * p.Quantity
                                                 }).ToList();

            var finalCartView = new FinalCartModel();
            finalCartView.cartViewModel = cardViewModel;
            finalCartView.TotalAmount = cartManager.GetBillAmount();
            finalCartView.TotalItem = cartManager.GetCartItemsCount();
            return View("MyOrder", finalCartView);
        }

        public ActionResult Cart()
        {
            cartManager = GetcartManager();
            var cartItems = cartManager.GetAllCartItems();
            List<CartViewModel> cardViewModel = (from p in cartItems
                                                 select new CartViewModel
                                                 {
                                                     ProductID = p.ProductID,
                                                     Name = p.Name,
                                                     Quantity = p.Quantity,
                                                     Price = p.Price,
                                                     Description = p.Description,
                                                     Catagory = p.Catagory,
                                                     Amount = p.Price * p.Quantity
                                                 }).ToList();
            var finalCartView = new FinalCartModel();
            finalCartView.cartViewModel = cardViewModel;
            finalCartView.TotalAmount = cartManager.GetBillAmount();
            finalCartView.TotalItem = cartManager.GetCartItemsCount();
            return View("MyOrder", finalCartView);

        }
    }
}