using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SanBongDa.Areas.Admin.Controllers
{
    public class HoaDonController : Controller
    {
        //
        // GET: /Admin/HoaDon/

        public ActionResult Index()
        {
            var iplHD = new HoaDonModel();
            var model = iplHD.ListAll();
            return View(model);
        }

        //
        // GET: /Admin/HoaDon/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Admin/HoaDon/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Admin/HoaDon/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Admin/HoaDon/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Admin/HoaDon/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Admin/HoaDon/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Admin/HoaDon/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
