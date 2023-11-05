namespace Ejercicio5;

public class Library
{
    public List<Book> Books = new List<Book>();

    public void AddBook(Book book)
    {
        foreach (var value in Books)
        {
            if (value.Isbn != book.Isbn)
            {
                Books.Add(book);
                Console.WriteLine($"Libro added");
            }
        }
    }

    public void DeleteBook(string isbn)
    {
        foreach (var value in Books)
        {
            if (value.Isbn == isbn)
            {
                Books.Remove(value);
                Console.WriteLine($"Libro eliminado");
            }
        }
    }

    public void CheckBook(DateTime year, string genre, string author)
    {
        foreach (var value in Books)
        {
            if (value.Year == year && value.Genre == genre && value.Author == author)
            {
                Console.WriteLine($"El libro que ha consultado: ISBN - {value.Isbn}, Year - {value.Year}, Author - {value.Author}, Genre - {value.Genre}, Editorial - {value.Editorial}");
            }            
        }
    }

    public void ShowLibrary()
    {
        Console.WriteLine("Biblioteca con los libros:");
        foreach (var value in Books)
        {
            Console.WriteLine($"ISBN: {value.Isbn}, Año de publicación: {value.Year}, Género: {value.Genre}, Autor: {value.Author}, Editorial: {value.Editorial}");
        }
    }
    public override string ToString() => $"";
}