using AuthApp.Data;
using AuthApp.Models.DTO;

namespace AuthApp.Models
{
    public class FormWithResultModel
    {
        public BookDto BookCreateDto { get; set; } = new();
        public Book? Book { get; set; }
    }
}
