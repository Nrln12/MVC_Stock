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
    public class CategoryController : Controller
    {


        // GET: Category
        MvcDbStockEntities db = new MvcDbStockEntities();
        public ActionResult Index(int page=1)
        {
            //var degerler = db.TBL_Categories.ToList();
            var degerler = db.TBL_Categories.ToList().ToPagedList(page, 4);
            return View(degerler);
        }
        [HttpGet]
        public ActionResult NewCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewCategory(TBL_Categories p1)
        {
            if (!ModelState.IsValid)
            {
                return View("NewCategory");
            }
            db.TBL_Categories.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var category = db.TBL_Categories.Find(id);
            db.TBL_Categories.Remove(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult ReturnCategory(int id)
        {
            var ctgr = db.TBL_Categories.Find(id);
            return View("ReturnCategory", ctgr);
        }
        public ActionResult Update(TBL_Categories p1)
        {
            var ctg = db.TBL_Categories.Find(p1.CategoryID);
            ctg.CategoryName = p1.CategoryName;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}