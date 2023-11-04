public class Book
{
    private string Isbn { get; }
    private DateTime Year;
    private string Author;
    private string Genre;
    private string Editorial;
    
    public Book(string isbn, DateTime year, string author, string genre, string editorial)
    {
        Isbn = isbn;
        Year = year;
        Author = author;
        Genre = genre;
        Editorial = editorial;
    }
    
    
}