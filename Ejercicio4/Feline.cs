namespace Ejercicio4;

public class Feline : Animal
{
    public void Roam()
    {
        Console.WriteLine($"{this.GetType()} is roaming");
    }
}