namespace Ejercicio6;

public class Execute
{
    public static void Main()
    {
        Square square = new Square(4);
        square.AreaSquare(square);
        Console.WriteLine($"{square}");
        
        Rectangle rectangle = new Rectangle(4, 2);
        rectangle.AreaRectangle(rectangle);
        Console.WriteLine($"{rectangle}");
        
        Circle circle = new Circle(4);
        circle.AreaCircle(circle);
        Console.WriteLine($"{circle}");
    }
}