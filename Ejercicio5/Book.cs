namespace Ejercicio5;

public class Book
{
    public string Isbn { get; }
    public int Year { get; }
    public string Author { get; }
    public string Genre { get; }
    public string Editorial { get; }
    
      public Book(string isbn, int year, string author, string genre, string editorial)
      {
          Isbn = isbn;
          Year = year;
          Author = author;
          Genre = genre;
          Editorial = editorial;
      }
      
      public override string ToString() => $"ISBN: {Isbn}, Año Publicacion: {Year}, Author: {Author}, Genre: {Genre}, Editorial: {Editorial}";
}