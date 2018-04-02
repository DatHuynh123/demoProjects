using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SanBongDa.Areas.Admin.Controllers
{
    public class SanController : Controller
    {
        //
        // GET: /Admin/San/

        public ActionResult Index()
        {
            var iplSan = new SanModel();
            var model = iplSan.ListAll();
            return View(model);
        }

        //
        // GET: /Admin/San/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Admin/San/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Admin/San/Create

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
        // GET: /Admin/San/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Admin/San/Edit/5

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
        // GET: /Admin/San/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Admin/San/Delete/5

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
