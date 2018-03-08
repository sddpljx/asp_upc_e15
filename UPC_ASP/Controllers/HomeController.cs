using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UPC_ASP.Controllers
{
    public class ShareController : Controller
    {
        public ActionResult ClaSch()
        {
            return View();
        }
        public ActionResult MSForms()
        {
            return View();
        }
        public ActionResult Media()
        {
            return View();
        }
        public ActionResult download()
        {
            return View();
        }

        
    }
    public class WorkController : Controller
    {
        public ActionResult Homework()
        {
            return View();
        }
        public ActionResult djtd()
        {
            return View();
        }
        public ActionResult gddlfx()
        {
            return View();
        }
        public ActionResult dltd()
        {
            return View();
        }
    }
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        
    }
}