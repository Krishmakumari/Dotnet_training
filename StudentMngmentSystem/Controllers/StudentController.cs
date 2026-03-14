using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentMngmentSystem.Data;
using StudentMngmentSystem.Models;

namespace StudentMngmentSystem.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var students = _context.Students
                .Include(s => s.Department)
                .Include(s => s.Course)
                .ToList();
            return View(students);
        }

        public IActionResult Create()
        {
            ViewBag.DepartmentId = new SelectList(_context.Departments, "DepartmentId", "DepartmentName");
            ViewBag.CourseId = new SelectList(_context.Courses, "CourseId", "CourseName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Add(student);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DepartmentId = new SelectList(_context.Departments, "DepartmentId", "DepartmentName", student.DepartmentId);
            ViewBag.CourseId = new SelectList(_context.Courses, "CourseId", "CourseName", student.CourseId);
            return View(student);
        }

        public IActionResult Edit(int id)
        {
            var student = _context.Students.Find(id);
            ViewBag.DepartmentId = new SelectList(_context.Departments, "DepartmentId", "DepartmentName", student?.DepartmentId);
            ViewBag.CourseId = new SelectList(_context.Courses, "CourseId", "CourseName", student?.CourseId);
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Update(student);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DepartmentId = new SelectList(_context.Departments, "DepartmentId", "DepartmentName", student.DepartmentId);
            ViewBag.CourseId = new SelectList(_context.Courses, "CourseId", "CourseName", student.CourseId);
            return View(student);
        }

        public IActionResult Delete(int id)
        {
            var student = _context.Students
                .Include(s => s.Department)
                .Include(s => s.Course)
                .FirstOrDefault(s => s.StudentId == id);
            return View(student);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var student = _context.Students.Find(id);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}