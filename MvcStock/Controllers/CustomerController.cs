using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStock.Models.Entity;
namespace MvcStock.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        MvcDbStockEntities db = new MvcDbStockEntities();
        public ActionResult Index(string p)
        {
            var degerler = from d in db.TBL_Customers select d;
            if (!string.IsNullOrEmpty(p))
            {
                degerler = degerler.Where(m => m.CustomerName.Contains(p));
            }
            return View(degerler.ToList());
            //var degerler = db.TBL_Customers.ToList();
            //return View(degerler);
        }
        [HttpGet]
        public ActionResult NewCustomer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewCustomer(TBL_Customers p1)
        {
            if (!ModelState.IsValid)
            {
                return View("NewCustomer");
            }
            db.TBL_Customers.Add(p1);
            db.SaveChanges();
            return View();
        }
        public ActionResult Delete(int id)
        {
            var customer = db.TBL_Customers.Find(id);
            db.TBL_Customers.Remove(customer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult ReturnCustomer(int id)
        {
            var cstmr = db.TBL_Customers.Find(id);
            return View("ReturnCustomer", cstmr);
         
        }
        public ActionResult Update(TBL_Customers p1)
        {
            var customer = db.TBL_Customers.Find(p1.CustomerID);
            customer.CustomerName = p1.CustomerName;
            customer.CustomerLastName = p1.CustomerLastName;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}