using CSCI4927_Gainers.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CSCI4927_Gainers.Controllers
{
    public class MessagesController : Controller
    {
        private readonly IUserRepository _userRepo;
        private readonly IMessageRepository _messageRepo;

        public MessagesController(IUserRepository userRepo, IMessageRepository messageRepo)
        {
            _userRepo = userRepo;
            _messageRepo = messageRepo;
        }
        // GET: MessagesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MessagesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MessagesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MessagesController/Create
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

        // GET: MessagesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MessagesController/Edit/5
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

        // GET: MessagesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MessagesController/Delete/5
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
