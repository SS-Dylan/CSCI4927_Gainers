﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CSCI4927_Gainers.Controllers
{
    public class LandingController : Controller
    {
        // GET: LandingController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }


        // GET: LandingController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LandingController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LandingController/Create
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

        // GET: LandingController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LandingController/Edit/5
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

        // GET: LandingController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LandingController/Delete/5
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
