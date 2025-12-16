using DZ3._4.Pages.Books;
using Microsoft.VisualBasic;
using System.Linq;
namespace DZ3._4.Pages.Services
{
    public class BookService : IBookService
    {
        private readonly IList<Book> books = [
            new Book(
                1,
                "Евгений Онегин",
                "Пушкин",
                "Александр",
                "Сергеевич",
                "Роман в стихах",
                "Москва",
                1833),
            new Book(
                2,
                "Преступление и наказание",
                "Достоевский",
                "Фёдор",
                "Михайлович",
                "Роман",
                "Русский вестник",
                1866),
            new Book(
                3,
                "Война и мир",
                "Толстой",
                "Лев",
                "Николаевич",
                "Роман-эпопея",
                "Русский вестник",
                1869)
            ];
        public IList<Book> GetLibrary()
        {
            return books;
        }
        public int GetLibraryCount()
        {
            return books.Count();
        }
        public Book GetBookId (int id)
        {
            foreach (var book in books)
            {
                if (book.Id == id)
                    return book;
                else
                    Console.WriteLine("Not found");
            }
        }
    }
}

