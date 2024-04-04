namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1, "ISBN 12312-31231", "D. Knuth", "Книга карлсон"),
            new Book(2, "ISBN 12312-31345", "A. Kalaghen",  "Книга Золотой горшочек"),
            new Book(3, "ISBN 12312-31689", "U. Goldenfold", "Книга Красавица и чудовище")
        };

        public Book[] GetAllByIsbn(string isbn)
        {
            return books.Where(book => book.Isbn == isbn).ToArray();
        }

        public Book[] GetAllByTitleOrAuthor(string query)
        {
            return books.Where(book => book.Author.Contains(query) || book.Title.Contains(query)).ToArray();
        }
    }
}
