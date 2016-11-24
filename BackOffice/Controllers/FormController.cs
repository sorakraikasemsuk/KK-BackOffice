using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackOffice.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult FormGeneral_Index()
        {
            return View();
        }

        public ActionResult FormAdvanced_Index()
        {
            return View();
        }

        public ActionResult FormValidation_Index()
        {
            return View();
        }

        public ActionResult FormWizard_Index()
        {
            return View();
        }

        public ActionResult FormUpload_Index()
        {
            return View();
        }

        public ActionResult FormButtons_Index()
        {
            return View();
        }

    }
}