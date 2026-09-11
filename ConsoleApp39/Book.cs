namespace ConsoleApp39
{
    internal class Book
    {
        Book[] books = new Book[5];
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublishedDate { get; set; }
        public double Price { get; set; }
        public Book(int id, string title, string author, DateTime publishedDate, double price)
        {
            Id = id;
            Title = title;
            Author = author;
            PublishedDate = publishedDate;
            Price = price;
        }
    }
}
