namespace Ejercicio5;

public class Library
{
    Book[] books = new Book[10];

    public void AddBook(Book book)
    {
        for (int i = 0; i < books.Length-1; i++)
        {
            books[i] = book;
        }
    }

    public void DeleteBook(string isbn)
    {
        for (int i = 0; i < books.Length-1; i++)
        {
            
        }
    }

    public void CheckBook(DateTime year, string genre, string author)
    {
        
    }
}