namespace Ejercicio5;

public class Editorial
{
    private string Name { get; }
    private DateTime YearCreation { get; }

    public Editorial(string name, DateTime yearCreation)
    {
        Name = name;
        YearCreation = yearCreation;
    }
}