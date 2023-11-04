namespace Ejercicio6;

public class Rectangle
{
    private double Side1;
    private double Side2;
    private double Area;

    public Rectangle(double side1, double side2)
    {
        Side1 = side1;
        Side2 = side2;
    }
    
    public void AreaRectangle(Rectangle rectangle)
    {
        Area = rectangle.Side1*rectangle.Side2;
    }

    public override string ToString() => $"El area del rectangulo es: {Area}";
}