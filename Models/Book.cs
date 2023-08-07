using System.ComponentModel.DataAnnotations;

namespace BookstoreProject.Models
{
    public class Book
    {

        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required, MaxLength(14)]
        public string ISBN { get; set; }

        [Required, DataType(DataType.Currency)]
        public int Price { get; set; }

        [Required, MaxLength(300)]
        public string Synopsis { get; set; }
    }
}
