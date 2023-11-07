using System.Collections;
using System.Diagnostics;

namespace Ejercicio5;

public class Library: IEnumerable<Book>
{
    // public Book[] books = new Book[10];
    //
    // public void AddBook(Book book)
    // {
    //     foreach (var value in books)
    //     {
    //         for (int i = 0; i < books.Length; i++)
    //         {
    //             if (value.Isbn != book.Isbn)
    //             {
    //                 books[i] = book;
    //                 Console.WriteLine($"Libro añadido");
    //             }
    //         }
    //     }
    // }

    
    public List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        if (books.Contains(book)) return;
        books.Add(book);
    }

    public void DeleteBook(Book book)
    {
        if (!books.Contains(book)) return;
        books.Remove(book);
    }

    public IEnumerable<Book> ByYear(int year)
    {
        return books.Where(b => b.Year == year);
    }
    
    public IEnumerable<Book> ByGenre(string genre)
    {
        return books.Where(b => b.Genre == genre);
    } 
    
    public IEnumerable<Book> ByAuthor(string author)
    {
        return books.Where(b => b.Author == author);
    }


    public IEnumerator<Book> GetEnumerator()
    {
        return books.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}