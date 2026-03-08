using LibraryBookMngmentSystem.Models;
using LibraryBookMngmentSystem.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryBookMngmentSystem.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _repo;

        public BookController(IBookRepository repo)
        {
            _repo = repo;
        }


        public IActionResult List()
        {
            var books = _repo.GetAllBooks();
            return View(books);
        }

        public IActionResult Details(int id)
        {
            var book = _repo.GetBookById(id);
            return View(book);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            _repo.AddBook(book);
            return RedirectToAction("List");
        }

        public IActionResult Edit(int id)
        {
            var book = _repo.GetBookById(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            _repo.UpdateBook(book);
            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            _repo.DeleteBook(id);
            return RedirectToAction("List");
        }
    }
}
