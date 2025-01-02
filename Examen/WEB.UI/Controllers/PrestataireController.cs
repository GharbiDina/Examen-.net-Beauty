﻿using AM.ApplicationCore.Interfaces;
using ApplicationCore.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WEB.UI.Controllers
{
    public class PrestataireController : Controller
    {
        readonly IService<Prestataire> PrestataireService;
        public PrestataireController(IService<Prestataire> PrestataireService)
        {
            this.PrestataireService = PrestataireService;
            
        }
        // GET: PrestataireController1cs
        public ActionResult Index()
        {
            return View(PrestataireService.GetAll().OrderBy(h => h.PrestataireNom));
        }

        // GET: PrestataireController1cs/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PrestataireController1cs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PrestataireController1cs/Create
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

        // GET: PrestataireController1cs/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PrestataireController1cs/Edit/5
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

        // GET: PrestataireController1cs/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PrestataireController1cs/Delete/5
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
