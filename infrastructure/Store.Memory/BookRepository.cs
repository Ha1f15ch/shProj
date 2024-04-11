
namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1, "ISBN 12312-31231", "D. Knuth", "Книга карлсон", "description", 1500m),
            new Book(2, "ISBN 12312-31345", "A. Kalaghen",  "Книга Золотой горшочек", "Description Description", 5500m),
            new Book(3, "ISBN 12312-31689", "U. Goldenfold", "Книга Красавица и чудовище", "Descriiption 2", 6600m)
        };

        public Book[] GetAllByIds(IEnumerable<int> bookIds)
        {
            var foundBooks = from book in books join bookId in bookIds on book.Id equals bookId select book;
            return foundBooks.ToArray();
        }

        public Book[] GetAllByIsbn(string isbn)
        {
            return books.Where(book => book.Isbn == isbn).ToArray();
        }

        public Book[] GetAllByTitleOrAuthor(string query)
        {
            return books.Where(book => book.Author.Contains(query) || book.Title.Contains(query)).ToArray();
        }

        public Book GetById(int id)
        {
            return books.Single(book => book.Id == id);
        }
    }
}
