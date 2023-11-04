namespace Ejercicio4;

public class Cow : Animal
{
    public override void Eat()
    {
        Console.WriteLine($"{this.GetType().Name} is eating");
    }

    public override void MakeNoise()
    {
        Console.WriteLine($"Muuuuu");
    }
}