namespace DZ3._4.Pages.Books
{
    public class Book
    {
        public string? BookTitle { get; set; }//название книги

        public string? AuthorSurname { get; set; }//фамилия автора

        public string? AuthorFirstname { get; set; }//имя автора

        public string? AuthorSecondname { get; set; }//отчество автора

        public string? Style { get; set; }//стиль книги

        public string? Publishing { get; set; }//издательство

        int? Year   { get; set; }//год издания

        public Book (string _BookTitle, string _AuthorSurname, string _AuthorFirstname, string _AuthorSecondname,
            string _Style, string _Publishing, int _Year)
        {
            BookTitle= _BookTitle;
            AuthorSurname= _AuthorSurname;
            AuthorFirstname= _AuthorFirstname;
            AuthorSecondname= _AuthorSecondname;
            Style= _Style;
            Publishing= _Publishing;
            Year= _Year;
        }

    }
}
