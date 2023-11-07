namespace Ejercicio5;

public class Editorial
{
    private string Name { get; }
    private int YearCreation { get; }

    public Editorial(string name, int yearCreation)
    {
        Name = name;
        YearCreation = yearCreation;
    }
    
    public override string ToString() => $"Nombre: {Name}, Año creacion: {YearCreation}";
}