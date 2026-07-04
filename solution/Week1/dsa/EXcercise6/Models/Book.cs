namespace Exercise6_LibraryManagement.Models
{
    public class Book
    {
        public int BookId { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public Book(int id, string title, string author)
        {
            BookId = id;
            Title = title;
            Author = author;
        }

        public override string ToString()
        {
            return $"Book ID: {BookId}, Title: {Title}, Author: {Author}";
        }
    }
}