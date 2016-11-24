using BackOffice.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackOffice.Controllers
{
    public class HomeController : Controller
    {
        private  IHomeIndexRepository data;

        public HomeController(IHomeIndexRepository Idata)
        {
            data = Idata;
        }
        public ActionResult Index()
        {
            ViewBag.Version = data.appVersion().ToList();
            return View();
        }

        public ActionResult Index2()
        {
            return View();
        }

        public ActionResult Index3()
        {
            return View();
        }
    }
}