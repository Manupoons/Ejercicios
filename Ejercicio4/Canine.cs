namespace Ejercicio4;

public class Canine : Animal
{
    public void Roam()
    {
        Console.WriteLine($"{this.GetType()} is roaming");
    }
}