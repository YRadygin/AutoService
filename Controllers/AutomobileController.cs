using AutoService.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoService.Controllers
{
    public class AutomobileController : Controller
    {
        private readonly AutoServiceContext _context;

        public AutomobileController(AutoServiceContext context)
        {
            _context = context;
        }

        // GET: AutomobileController
        public string Index(int id)
        {
            var listAuto = _context.Automobile.Where(m => m.Id_client == id);
            return JsonConvert.SerializeObject(listAuto);
        }

        // GET: AutomobileController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AutomobileController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AutomobileController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AutomobileController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AutomobileController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AutomobileController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AutomobileController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
