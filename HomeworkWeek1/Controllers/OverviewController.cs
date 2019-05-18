using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeworkWeek1.Models;
using System.Data.Entity;

namespace HomeworkWeek1.Controllers
{
    public class OverviewController : Controller
    {
        private Entities db = new Entities();
        // GET: Overview
        public ActionResult Index()
        {
            var a = db.vwCustomerOverview.ToList();
            return View(db.vwCustomerOverview.ToList());
        }
    }
}