
using Microsoft.AspNetCore.Mvc;
using WebApplication1minor.Models;

namespace WebApplication1Minor.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private object userAccounts;

        public UserController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public IActionResult Index()
        {
            var list = _applicationDbContext.UserAccounts.ToList();
            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(UserAccount userAccount)
        {
            if (ModelState.IsValid)
            {
                _applicationDbContext.UserAccounts.Add(userAccount);
                return RedirectToAction("Index");
            }
            return View(userAccounts);
        }

        private IActionResult View(object userAccounts)
        {
            throw new NotImplementedException();
        }
    }
}