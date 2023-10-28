using System.ComponentModel.DataAnnotations;

namespace AuthApp.Models.DTO
{
    public class BookDto
    {
        [Required(ErrorMessage = "Title is required")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Author is required")]
        public string? Author { get; set; }

        [Range(1900, 2023, ErrorMessage = "Year must be between 1900 and 2022")]
        public int Year { get; set; }

        [Required(ErrorMessage = "ISBN is required")]
        [StringLength(10, ErrorMessage = "ISBN cannot be longer than 10 characters")]
        public string? Isbn { get; set; }
    }
}
