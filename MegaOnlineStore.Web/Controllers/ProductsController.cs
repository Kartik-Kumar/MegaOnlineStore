using MegaOnlineStore.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
namespace MegaOnlineStore.Web.Controllers
{
    public class ProductsController : Controller
    {

        IProductManager mgr = new ProductManager();
        // GET: Products
        public ActionResult List(string name,int? page)
        {
            
            if (string.IsNullOrEmpty(name))
            {
                var prd = mgr.GetProduct().ToList().ToPagedList(page ?? 1, 2);
                return View("List",prd);
            }
            var products = mgr.GetProductByName(name);
            return View("List",products.ToPagedList(page ?? 1, 2));
        }

        [ChildActionOnly]
        public PartialViewResult RendorCatagoryDropDown()
        {
            var prd = mgr.GetProduct().ToList();
            var catList = mgr.GetAllCatagory();
            IEnumerable<SelectListItem> items = from i in catList
                                                select new SelectListItem { Text = i, Value = i };
            ViewBag.name = items;

            return PartialView("_ListCatagoryPartial");
        }

        [ChildActionOnly]
        public PartialViewResult RenderCatagoryBar()
        {
            var cat = mgr.GetAllCatagory();
            /*IEnumerable<SelectListItem> items = from i in cat
                                                select new SelectListItem { Text = i, Value = i };
            ViewBag.name = items;

            return PartialView("_ListCatagoryBarPartial");*/

            return PartialView("_ListCatagoryBarPartial", cat);
        }

        /*public ActionResult Search(string name)
        {
            //if (string.IsNullOrEmpty(name)) return RedirectToAction("List");

            //string name = Request["name"];
            var pList = mgr.GetProductByName(name);
            return View("List",pList);
        }*/
    }
}