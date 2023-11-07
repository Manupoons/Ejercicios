namespace Ejercicio5;

public class Execute
{
    public static void Main()
    {
        Library libreria = new Library();
        
        Book book1 = new Book("1234", 2005, "Jose", "Drama", "Mana");
        Book book2 = new Book("4321", 2002, "Pepe", "Drama", "Mona");

        Editorial edit = new Editorial("Mana", 1999);
        Author autor = new Author("Jose", "Perona", 1970);
        
        
        libreria.AddBook(book1);
        libreria.AddBook(book2);
        libreria.DeleteBook(book1);

        libreria.ByGenre("Jose");

        

    }
}