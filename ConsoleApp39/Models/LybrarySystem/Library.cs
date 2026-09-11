namespace ConsoleApp39.Models.LybrarySystem
{
    internal class Library
    {
        public int FindBooks(Book[] books, DateTime minDate, DateTime maxDate, double minPrice)
        {
            int count = 0;
            foreach (var book in books)
            {
                if (book.PublishedDate >= minDate && book.PublishedDate <= maxDate &&
                    book.Price >= minPrice)
                {
                    Console.WriteLine($"Id: {book.Id}, Title: {book.Title}, Author: {book.Author}, Published Date: {book.PublishedDate.ToShortDateString()}, Price: {book.Price}");
                    count++;
                }
            }
            return count;
        }
    }
}
