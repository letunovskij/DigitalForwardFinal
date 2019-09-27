using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LocateAndChack.Controllers
{
    public class DefectoskopController : Controller
    {
        // GET: Defectoskop
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost("UploadFiles")]
        public JsonResult PostData()
        {
            return null;
        }

        // GET: Defectoskop/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Defectoskop/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Defectoskop/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Defectoskop/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Defectoskop/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Defectoskop/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Defectoskop/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}