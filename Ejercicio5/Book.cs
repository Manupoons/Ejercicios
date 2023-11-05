public class Book{
    public string Isbn { get; }
    public DateTime Year;
    public string Author;
    public string Genre;
    public string Editorial;
    
      public Book(string isbn, DateTime year, string author, string genre, string editorial)
      {
          Isbn = isbn;
          Year = year;
          Author = author;
          Genre = genre;
          Editorial = editorial;
      }
}