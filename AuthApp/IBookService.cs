using AuthApp.Data;
using AuthApp.Models.DTO;

namespace AuthApp
{
    public interface IBookService
    {
        Task<Book> CreateBookAsync(BookDto bookDto);
        ICollection<Book> GetBooks();
        Book GetBookById(long id);
        Task DeleteBookByIdAsync(long id);
        Task<Book> UpdateBookAsync(Book book);
    }
}
