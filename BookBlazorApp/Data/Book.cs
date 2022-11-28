
namespace BookBlazorApp.Data
{
    public class Book
    {
        public Book(string title, string author, string genre)
        {
            Title = title;
            Author = author;
            Genre = genre;
        }

        public Book() : this("Untitled", "Unknown","Misc") { }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
    }
}