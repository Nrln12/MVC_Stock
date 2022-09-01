﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStock.Models.Entity;
namespace MvcStock.Controllers
{
    public class SalesController : Controller
    {
        // GET: Sales
        MvcDbStockEntities db = new MvcDbStockEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult NewSale()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewSale(TBL_Satishlar p)
        {
            db.TBL_Satishlar.Add(p);
            db.SaveChanges();
            return View("Index");
        }
    }
}