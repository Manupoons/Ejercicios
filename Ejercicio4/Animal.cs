public abstract class Animal
{
    public int Food { get; set; }

    public virtual void Eat()
    {
        Console.WriteLine($"{this.GetType()} is eating");
    }

    public static string Sleep()
    {
        return ($"Duermo");
    }

    public static string Move()
    {
        return ($"Me muevo");
    }

    public virtual void MakeNoise()
    {
        Console.WriteLine($"Ruido");
    }

    public override string ToString() => $"";
}