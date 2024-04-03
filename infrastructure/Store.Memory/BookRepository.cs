namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1, "Книга карлсон"),
            new Book(2, "Книга Золотой горшочек"),
            new Book(3, "Книга Красавица и чудовище")
        };
        public Book[] GetAllByTitle(string titlePart)
        {
            return books.Where(book => book.Title.Contains(titlePart)).ToArray();
        }
    }
}
