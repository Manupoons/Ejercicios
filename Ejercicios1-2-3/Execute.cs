namespace Ejercicios;

public class Execute
{
    public static void Main()
    {
        Point punto1 = new Point(2, 3);
        Point punto2 = new Point(3, 4);
        Line line = new Line(punto1, punto2);
        
        Console.WriteLine($"La distancia de la linea es: {Line.Distance(punto1, punto2)}");
    }
}