using AuthApp.Data;
using AuthApp.Models.DTO;
using AutoMapper;

namespace AuthApp.Services
{
    public class BookService : IBookService
    {
        private protected readonly ApplicationDbContext _context;
        private protected readonly IMapper _mapper;
        public BookService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Book> CreateBookAsync(BookDto bookDto)
        {
            var newBook = _mapper.Map<Book>(bookDto);

            _context.Books.Add(newBook);

            await _context.SaveChangesAsync();

            return newBook;
        }

        public ICollection<Book> GetBooks()
        {
            return _context.Books.ToList();
        }

        public Book GetBookById(long id)
        {
            return _context.Books.FirstOrDefault(x => x.Id == id) ?? throw new ArgumentException("No such entity:" + nameof(Book));
        }

        public async Task DeleteBookByIdAsync(long id)
        {
            var userToRemove = _context.Books.SingleOrDefault(x => x.Id == id);

            _context.Remove(userToRemove ?? throw new ArgumentException("No such entity:" + nameof(Book)));

            await _context.SaveChangesAsync();
        }

        public async Task<Book> UpdateBookAsync(Book book)
        {
            var bookToUpdate = await _context.Books.FindAsync(book.Id) ?? throw new ArgumentException("No such entity:" + nameof(Book));

            bookToUpdate.Title = book.Title;
            bookToUpdate.Author = book.Author;
            bookToUpdate.Year = book.Year;
            bookToUpdate.Isbn = book.Isbn;

            await _context.SaveChangesAsync();

            return bookToUpdate;
        }
    }
}
