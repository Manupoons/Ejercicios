namespace Ejercicio4;

public class Execute
{
    public static void Main()
    {
        Cow vaca = new Cow();
        Cat gato = new Cat();
        Lion leon = new Lion();
        Dog perro = new Dog();
        Wolf lobo = new Wolf();
        
        vaca.Eat();
        vaca.MakeNoise();
        gato.MakeNoise();
        leon.MakeNoise();
        perro.MakeNoise();
        lobo.MakeNoise();
    }
}