using Microsoft.AspNetCore.Mvc;
using StudentMngmentSystem.Data;

namespace StudentMngmentSystem.Controllers
{
    public class TeacherDashboardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TeacherDashboardController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}