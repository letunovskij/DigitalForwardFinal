using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CheckAndLocate.ViewModels;

namespace LocateAndChack.Controllers
{
    public class DefectoskopController : Controller
    {
        // GET: Defectoskop
        public ActionResult Index()
        {
            return View();
        }

        //[RequestSizeLimit(100_000_000_000_000)]
        [DisableRequestSizeLimit]
        [HttpPost("UploadFiles")]
        public async Task<IActionResult> PostData(List<IFormFile> files)
        {
            List<DefectoskopViewModel> defVmList = new List<DefectoskopViewModel>();

            long size = files.Sum(f => f.Length);

            // full path to file in temp location
            var filePath = Path.GetTempFileName();
            var count = 0;
            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    //using (var stream = new FileStream(filePath, FileMode.Create))
                    //{
                    //    await formFile.CopyToAsync(stream);
                    //}

                    var result = new StringBuilder();
                    using (var reader = new StreamReader(formFile.OpenReadStream()))
                    {
                        var head = reader.ReadLine();
                        while (reader.Peek() >= 0 && count < 1000)
                        {
                            var currentRow = reader.ReadLine();
                            DefectoskopViewModel defVm = new DefectoskopViewModel(currentRow);
                            defVmList.Add(defVm);
                            count++;
                        }
                    }
                }
            }
            // TODO 1) Analyze data. 
            // 2) Display the page with some initial data (There are different gistograms, links between data columns). 
            // 3) Display the page with the result from python classifier (also display reports with pdf.js and maps with openlayers).
            return View("Report", defVmList);
            //Ok(new { count = files.Count, size, filePath }); // View Index 
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