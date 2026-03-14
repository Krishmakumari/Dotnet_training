using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentMngmentSystem.Data;
using StudentMngmentSystem.ViewModels;

namespace StudentMngmentSystem.Controllers
{
    public class StudentDashboardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentDashboardController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Profile()
        {
            var email = HttpContext.Session.GetString("UserEmail");
            if (email == null) return RedirectToAction("Login", "Account");

            var student = _context.Students
                .Include(s => s.Department)
                .Include(s => s.Course)
                .FirstOrDefault(s => s.Email.ToLower() == email.ToLower());

            if (student == null)
                return View(null);

            var vm = new StudentProfileViewModel
            {
                StudentId = student.StudentId,
                StudentName = student.StudentName,
                Email = student.Email,
                PhoneNumber = student.PhoneNumber,
                Address = student.Address,
                DepartmentName = student.Department?.DepartmentName ?? string.Empty,
                CourseName = student.Course?.CourseName ?? string.Empty
            };

            return View(vm);
        }

        [HttpPost]
        public IActionResult Profile(StudentProfileViewModel vm)
        {
            var student = _context.Students.Find(vm.StudentId);
            if (student == null) return NotFound();

            student.PhoneNumber = vm.PhoneNumber;
            student.Address = vm.Address;
            _context.SaveChanges();

            TempData["Success"] = "Profile updated successfully.";
            return RedirectToAction("Profile");
        }
    }
}
