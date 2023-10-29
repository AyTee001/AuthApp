using AuthApp.Constants;
using AuthApp.Data;
using AuthApp.Models;
using AuthApp.Models.DTO;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthApp.Controllers
{
    /// <summary>
    /// Controller for managing books. Requires authoriyation
    /// </summary>
    [Authorize]
    public class BooksController : Controller
    {
        private readonly IBookService _bookService;
        private readonly IMapper _mapper;

        public BooksController(IBookService bookService, IMapper mapper)
        {
            _bookService = bookService;
            _mapper = mapper;
        }

        /// <summary>
        /// Returns a view displaying a list of books.
        /// </summary>
        /// <returns>The view with the list of books.</returns>
        [HttpGet]
        public IActionResult Index()
        {
            return View(_bookService.GetBooks());
        }

        /// <summary>
        /// Returns a view for adding a new book.
        /// </summary>
        /// <returns>The view for adding a new book.</returns>
        [Authorize(Roles = nameof(Roles.Admin))]
        [HttpGet]
        public IActionResult Add()
        {
            return View(new FormWithResultModel());
        }

        /// <summary>
        /// Processes the form submission to create a new book.
        /// </summary>
        /// <param name="form">The form data for creating a new book.</param>
        /// <returns>If the form is valid, it adds a new book and redirects to the 'Add' view. If the form is invalid, it returns the 'Add' view with validation errors.</returns>
        [Authorize(Roles = nameof(Roles.Admin))]
        [HttpPost]
        public async Task<IActionResult> Add(FormWithResultModel form)
        {
            if (ModelState.IsValid)
            {
                form.Book = await _bookService.CreateBookAsync(form.BookCreateDto);
            }

            return View("Add", form);
        }

        /// <summary>
        /// Returns a view for editing a book.
        /// </summary>
        /// <returns>The view for adding a new book with possibilities to either update or delete book.</returns>
        [Authorize(Roles = nameof(Roles.Admin))]
        [HttpGet]
        public IActionResult Edit(long id)
        {
            var book = _bookService.GetBookById(id);

            return View(book);
        }

        /// <summary>
        /// Processes the form submission to update an existing book.
        /// </summary>
        /// <param name="book">The updated information for the book.</param>
        /// <returns>If the form is valid, it updates the book and redirects to the 'Index' view. If the form is invalid, it returns the 'Edit' view with validation errors.</returns>
        [Authorize(Roles = nameof(Roles.Admin))]
        [HttpPost]
        public async Task<IActionResult> Edit(BookFullDto book)
        {
            if (ModelState.IsValid)
            {
                await _bookService.UpdateBookAsync(_mapper.Map<Book>(book));
                return RedirectToAction("Index");
            }
            return View(book);
        }

        /// <summary>
        /// Deletes an existing book.
        /// </summary>
        /// <param name="book">The book to be deleted.</param>
        /// <returns>Redirects to the 'Index' view after successful deletion.</returns>
        [Authorize(Roles = nameof(Roles.Admin))]
        [HttpPost]
        public async Task<IActionResult> Delete(BookFullDto book)
        {
            await _bookService.DeleteBookByIdAsync(book.Id);

            return RedirectToAction("Index");
        }
    }
}