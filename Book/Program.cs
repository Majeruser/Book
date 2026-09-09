namespace Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
            {
                new Book("J.K. Rowling", "Harry Potter and the Sorcerer's Stone", 309),
                new Book("George Orwell", "1984", 328),
                new Book("J.R.R. Tolkien", "The Hobbit", 310)
            };
        }
    }
}
