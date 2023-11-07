namespace Ejercicio6;

public class Execute
{
    public static void Main()
    {
        Square square = new Square(4);
        square.CalculateArea();
        
        Rectangle rectangle = new Rectangle(4, 5);
        rectangle.CalculateArea();
        
        Circle circle = new Circle(4);
        circle.CalculateArea();
        
    }
}