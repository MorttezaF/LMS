using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LMS.Models;

namespace LMS.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult login(Tbl_Users u)
        {
            LmsDB l = new LmsDB();
            var q = from a in l.Tbl_Users where a.username == u.username && a.password == u.password select a;
            if(q != null)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("login");
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}