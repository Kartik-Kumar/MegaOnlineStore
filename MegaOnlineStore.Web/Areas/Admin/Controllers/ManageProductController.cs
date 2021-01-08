using MegaOnlineStore.Business;
using MegaOnlineStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MegaOnlineStore.Web.Areas.Admin.Controllers
{
    public class ManageProductController : Controller
    {
        // GET: Admin/ManageProduct
        IProductManager mgr = new ProductManager();
        public ActionResult Index()
        {
            var pList = mgr.GetProduct();
            return View(pList);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                mgr.AddProduct(product);
                return RedirectToAction("Index");

            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            var pro = mgr.GetProductById(id);
            return View(pro);
        }
        [HttpPost]
        public ActionResult Edit(Product pr)
        {
            if (ModelState.IsValid)
            {
                mgr.UpdateProduct(pr);
                return RedirectToAction("Index");
            }
            
            return View();
        }

        public ActionResult Delete(int id)
        {
            mgr.DeleteProduct(id);
            TempData["Message"] = $"Product {id} is successfully deleted !!";
            return RedirectToAction("Index");
        }
    }
}