using Microsoft.AspNetCore.Mvc;
using WebApplication1minor.Models;

namespace WebApplication1Minor.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public TeacherController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public IActionResult Index()
        {
            var list = _applicationDbContext.Teachers.ToList();
            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                _applicationDbContext.Teachers.Add(teacher);
                return RedirectToAction("Index");
            }
            return View(teacher);
        }

    }
}