using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackOffice.Controllers
{
    public class LayoutsController : Controller
    {
        // GET: Layouts
        public ActionResult FixedSidebar_Index()
        {
            return View();
        }

        public ActionResult FixedFooter_Index()
        {
            return View();
        }
    }
}