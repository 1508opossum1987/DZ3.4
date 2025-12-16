using DZ3._4.Pages.Books;
using DZ3._4.Pages.Services;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DZ3._4.Pages
{
    public class BookDetailModel : PageModel
    {
        private readonly IBookService _bookService;

        public Book? Book { get; set; }

        public BookDetailModel(IBookService bookService)
        {
            _bookService = bookService;
        }

        public IActionResult OnGet(int id)
        {
            Book = _bookService.GetBookId(id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
