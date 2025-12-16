using DZ3._4.Pages.Services;
using DZ3._4.Pages.Books;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DZ3._4.Pages
{
    public class LibraryModel : PageModel
    {
        private readonly IBookService _bookService;
        public IList <Book> Books { get; set;  }= new List<Book>();
        public int BookCount  { get; set; }
        public LibraryModel(IBookService bookService)
        {
            _bookService = bookService;
        }
        public void OnGet()
        {
            Books = _bookService.GetLibrary();
            BookCount = _bookService.GetLibraryCount();
        }
    }
}
