namespace Ejercicio5;

public class Author
{
    public string Name { get; }
    public string SecondName { get; }
    public int YearBorn { get; }

    public Author(string name, string secondName, int yearBorn)
    {
        Name = name;
        SecondName = secondName;
        YearBorn = yearBorn;
    }
    
    public override string ToString() => $"Nombre: {Name}, Apellidos: {SecondName}, Año nacimiento: {YearBorn}";
}