using CSCI4927_Gainers.Models;
using CSCI4927_Gainers.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using CSCI4927_Gainers.Models.Entities;

namespace CSCI4927_Gainers.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserRepository _userRepo;

        public HomeController(ILogger<HomeController> logger, IUserRepository userRepo)
        {
            _logger = logger;
            _userRepo = userRepo;
        }

        public IActionResult Index(int userId)
        {
            if(userId == 0)
            {
                return RedirectToAction("Index", "Landing");
            }
            else
            {
                User user = _userRepo.Read(userId);
                if(user == null)
                {
                    return RedirectToAction("Index", "Landing");
                }
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}