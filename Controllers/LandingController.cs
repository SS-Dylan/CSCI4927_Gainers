using CSCI4927_Gainers.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using CSCI4927_Gainers.Models.Entities;

namespace CSCI4927_Gainers.Controllers
{
    public class LandingController : Controller
    {
        private readonly IUserRepository _userRepo;

        public LandingController(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

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

        [HttpPost]
        public IActionResult Register(User newUser)
        {
            if (ModelState.IsValid)
            {
                _userRepo.Create(newUser);
                return RedirectToAction("Index", "Home", new { userId = newUser.Id });
            }
            return View(newUser);
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            var users = _userRepo.ReadAll();
            foreach (var _user in users)
            {
                if(user.Email == _user.Email)
                {
                    if(user.Password == _user.Password)
                    {
                        return RedirectToAction("Index", "Home", new { userId = _user.Id });
                    }
                    else
                    {
                        // Valid email but incorrect password
                    }
                }
                else
                {
                    // No user with email found
                }
            }
            return View(user);
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
