using System.ComponentModel.DataAnnotations;

namespace GameStore.Frontend.Models
{
    public class GameDetails
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)] //sets name length limit to only 50
        public required string Name { get; set; }// = string.Empty;

        [Required(ErrorMessage = "The Genre field is required.")]
        public string? GenreId { get; set; }

        [Range(1, 100)]//valid range for the price, not 0 and not more than 100
        public decimal Price { get; set; }

        public DateOnly ReleaseDate { get; set; }
    }
}
