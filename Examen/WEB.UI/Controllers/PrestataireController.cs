﻿using AM.ApplicationCore.Interfaces;
using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using ApplicationCore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WEB.UI.Controllers
{
    public class PrestataireController : Controller
    {

        readonly IService<Prestataire> PrestataireService;
        readonly IService<Prestation> PrestationService;
        public PrestataireController(IService<Prestataire> PrestataireService, IService<Prestation> PrestationService)
        {
            this.PrestataireService = PrestataireService;
            this.PrestationService = PrestationService;
        }
   


        // GET: PrestataireController
        public ActionResult Index()
        {
            return View(PrestataireService.GetAll().OrderBy(h=>h.PrestataireNom));
        }

        public ActionResult Prestations(int prestataireId)
        {
            // Récupération des prestations associées au prestataire
            var prestations = PrestationService.GetAll().Where(p => p.PrestataireFK == prestataireId).ToList();

            // Passer les données à la vue
            return View(prestations);
        }
        // GET: PrestataireController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PrestataireController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PrestataireController/Create
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

        // GET: PrestataireController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PrestataireController/Edit/5
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

        // GET: PrestataireController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PrestataireController/Delete/5
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
