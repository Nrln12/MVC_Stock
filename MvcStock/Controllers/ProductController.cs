using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStock.Models.Entity;
using PagedList;
using PagedList.Mvc;
namespace MvcStock.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        MvcDbStockEntities db = new MvcDbStockEntities();
        public ActionResult Index()
        {
            var degerler = db.TBL_Products.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult NewProduct()
        {
            List<SelectListItem> degerler = (from i in db.TBL_Categories.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.CategoryName,
                                                 Value = i.CategoryID.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            return View();
        }

        [HttpPost]
        public ActionResult NewProduct(TBL_Products p1)
        {
            var ktg = db.TBL_Categories.Where(m => m.CategoryID == p1.TBL_Categories.CategoryID).FirstOrDefault();
            p1.TBL_Categories = ktg;
            db.TBL_Products.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var product = db.TBL_Products.Find(id);
            db.TBL_Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult ReturnProduct(int id)
        {
            var prdct = db.TBL_Products.Find(id);
            List<SelectListItem> degerler = (from i in db.TBL_Categories.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.CategoryName,
                                                 Value = i.CategoryID.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            return View("ReturnProduct", prdct);
        }
        public ActionResult Update(TBL_Products p)
        {
            var product = db.TBL_Products.Find(p.ProductID);
            product.ProductName = p.ProductName;
            //     product.ProductCategory = p1.ProductCategory;
            product.Marka = p.Marka;
            product.Cost = p.Cost;
            product.Stock = p.Stock;
            var ktg = db.TBL_Categories.Where(m => m.CategoryID == p.TBL_Categories.CategoryID).FirstOrDefault();
            product.ProductCategory = ktg.CategoryID;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}