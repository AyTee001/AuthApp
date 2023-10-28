using AuthApp.Constants;
using AuthApp.Data;
using AuthApp.Models;
using AuthApp.Models.DTO;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthApp.Controllers
{
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

        [HttpGet]
        public IActionResult Index()
        {
            return View(_bookService.GetBooks());
        }

        [Authorize(Roles = nameof(Roles.Admin))]
        [HttpGet]
        public IActionResult Add()
        {
            return View(new FormWithResultModel());
        }

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

        [Authorize(Roles = nameof(Roles.Admin))]
        [HttpGet]
        public IActionResult Edit(long id)
        {
            var book = _bookService.GetBookById(id);

            return View(book);
        }

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

        [Authorize(Roles = nameof(Roles.Admin))]
        [HttpPost]
        public async Task<IActionResult> Delete(BookFullDto book)
        {
            await _bookService.DeleteBookByIdAsync(book.Id);

            return RedirectToAction("Index");
        }
    }
}