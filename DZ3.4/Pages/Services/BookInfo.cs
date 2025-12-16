using DZ3._4.Pages.Books;

namespace DZ3._4.Pages.Services
{
    public class BookInfo : IBookInfo
    {
            public void WriteBookInfo(Book book)
            {
                Console.WriteLine($"Название книги: {book.BookTitle}");
                Console.WriteLine($"Автор: {book.AuthorSurname}, {book.AuthorFirstname}, {book.AuthorSecondname}");
                Console.WriteLine($"Стиль: {book.Style}");
                Console.WriteLine($"Издательство: {book.Publishing}");
                Console.WriteLine($"Год издания: {book.Year}");
            }
    }
}
