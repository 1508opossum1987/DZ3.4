using DZ3._4.Pages.Books;
namespace DZ3._4.Pages.Services
{
    public interface IBookService
    {
        IList<Book> GetLibrary();
        public int GetLibraryCount();
        public Book GetBookId(int id);
    }
}
