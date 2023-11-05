namespace Ejercicio5;

public class Author
{
    public string Name { get; }
    public string SecondName { get; }
    public DateTime YearBorn { get; }

    public Author(string name, string secondName, DateTime yearBorn)
    {
        Name = name;
        SecondName = secondName;
        YearBorn = yearBorn;
    }
}