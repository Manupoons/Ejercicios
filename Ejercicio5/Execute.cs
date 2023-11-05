namespace Ejercicio5;

public class Execute
{
    public static void Main()
    {
        Library libreria = new Library();
        
        Book book1 = new Book("1234", DateTime.Now, "Jose", "Drama", "Mana");
        Book book2 = new Book("4321", DateTime.Now, "Pepe", "Drama", "Mona");
        
        
        
        libreria.AddBook(book1);
        libreria.AddBook(book2);
        libreria.DeleteBook("1234");
        
        libreria.ShowLibrary();

        libreria.CheckBook(DateTime.Now, "Drama", "Jose");
        
        Console.WriteLine(libreria);
    }
}