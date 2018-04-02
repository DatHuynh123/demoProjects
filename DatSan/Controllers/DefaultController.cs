using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatSan.Controllers
{
    public class DefaultController : Controller
    {
        public ActionResult Default()
        {
            ViewBag.c = "Đây là trang chủ";
            ViewBag.t = "<H1>Đây là trang chủ</H1>";
            return View();
        }
        public ActionResult News()
        {
            
            return View();
        }

    } 
}
