using Microsoft.AspNetCore.Mvc;
using System.Linq;
using StudentMngmentSystem.Data;
using StudentMngmentSystem.Models;
using StudentMngmentSystem.ViewModels;

namespace StudentMngmentSystem.Controllers
{
    public class AccountController : Controller
    {
    private readonly ApplicationDbContext _context;

    public AccountController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(RegisterViewModel model)
    {
        if (ModelState.IsValid)
        {
            User user = new User
            {
                FullName = model.FullName,
                Email = model.Email,
                Password = model.Password,
                Role = model.Role
            };

            _context.Users.Add(user);
            _context.SaveChanges();

            return RedirectToAction("Login");
        }

        return View(model);
    }

    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(LoginViewModel model, string? returnUrl)
    {
        var user = _context.Users
            .FirstOrDefault(x => x.Email == model.Email && x.Password == model.Password);

        if (user == null)
        {
            ViewBag.Message = "Invalid Login";
            return View(model);
        }

        HttpContext.Session.SetInt32("UserId", user.UserId);
        HttpContext.Session.SetString("UserRole", user.Role);
        HttpContext.Session.SetString("UserEmail", user.Email);

        if (!string.IsNullOrEmpty(returnUrl))
            return Redirect(returnUrl);

        if (user.Role == "Teacher")
            return RedirectToAction("Index", "TeacherDashboard");

        return RedirectToAction("Index", "StudentDashboard");
    }

    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Login", "Account");
    }
    }
}
