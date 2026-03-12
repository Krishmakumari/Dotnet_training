using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryBookMngmentSystem.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BookId { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public decimal Price { get; set; }
    }
}