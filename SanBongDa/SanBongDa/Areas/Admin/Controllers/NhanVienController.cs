using Model;
using Model.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SanBongDa.Areas.Admin.Controllers
{
    public class NhanVienController : Controller
    {
        //
        // GET: /Admin/NhanVien/

        public ActionResult Index()
        {
            var iplNV = new NhanVienModel();
            var model = iplNV.ListAll();
            return View(model);
        }

        //
        // GET: /Admin/NhanVien/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Admin/NhanVien/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Admin/NhanVien/Create

        [HttpPost]
        public ActionResult Create(tblNhanVien collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // TODO: Add insert logic here

                    return RedirectToAction("Index");
                }
                return View(collection);
                
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Admin/NhanVien/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Admin/NhanVien/Edit/5

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
        // GET: /Admin/NhanVien/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Admin/NhanVien/Delete/5

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
