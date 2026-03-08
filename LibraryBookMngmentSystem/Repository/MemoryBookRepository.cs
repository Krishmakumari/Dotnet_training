using LibraryBookMngmentSystem.Models;
using System.Linq;

namespace LibraryBookMngmentSystem.Repository
{
    public class MemoryBookRepository : IBookRepository
    {
        private readonly List<Book> _books;

        public MemoryBookRepository()
        {
            _books = new List<Book>
            {
                new Book { BookId = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Price = 10.99m },
                new Book { BookId = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Price = 8.99m },
                new Book { BookId = 3, Title = "1984", Author = "George Orwell", Price = 9.99m }
            };
        }
        public void AddBook(Book book)
        {
            if (book.BookId == 0)
            {
                book.BookId = _books.Any() ? _books.Max(b => b.BookId) + 1 : 1;
            }
            _books.Add(book);
        }

        public void DeleteBook(int id)
        {
            var book = _books.FirstOrDefault(b => b.BookId == id);
            if(book!=null)
            {
                _books.Remove(book);
            }
        }

        public void UpdateBook(Book book)
        {
            var existing = _books.FirstOrDefault(b => b.BookId == book.BookId);
            if (existing != null)
            {
                existing.Title = book.Title;
                existing.Author = book.Author;
                existing.Price = book.Price;
            }
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _books;
        }

        public Book GetBookById(int id)
        {
            var book = _books.FirstOrDefault(b => b.BookId == id);
            return book;
        }
    }
}
