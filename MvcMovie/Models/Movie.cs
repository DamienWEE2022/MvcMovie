using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
<<<<<<< Updated upstream
        public string? Genre { get; set; }
=======
        public string? Location { get; set; }
        
        [Column(TypeName = "decimal(18, 2)")]
>>>>>>> Stashed changes
        public decimal Price { get; set; }
    }
}
