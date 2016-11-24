using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackOffice.Controllers
{
    public class TableController : Controller
    {
        // GET: Table
        public ActionResult Tables_Index()
        {
            return View();
        }

        public ActionResult TablesDynamic_Index()
        {
            return View();
        }
    }
}