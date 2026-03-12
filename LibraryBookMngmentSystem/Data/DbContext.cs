using LibraryBookMngmentSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryBookMngmentSystem.Data
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Treat BookId as a user-supplied value (not database-generated identity)
            modelBuilder.Entity<Book>()
                .Property(b => b.BookId)
                .ValueGeneratedNever();

            base.OnModelCreating(modelBuilder);
        }
    }
}