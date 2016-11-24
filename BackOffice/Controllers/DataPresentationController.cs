using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackOffice.Controllers
{
    public class DataPresentationController : Controller
    {
        // GET: DataPresentation
        public ActionResult ChartJs_Index()
        {
            return View();
        }

        public ActionResult ChartJs2_Index()
        {
            return View();
        }

        public ActionResult MorisJs_Index()
        {
            return View();
        }

        public ActionResult ECharts_Index()
        {
            return View();
        }

        public ActionResult OtherCharts_Index()
        {
            return View();
        }
    }
}