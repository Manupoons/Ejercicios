namespace Ejercicio6;

public class Rectangle: Shape
{
    private double Width { get; }
    private double Length { get; }
    

    public Rectangle(double width, double length)
    {
        Width = width;
        Length = length;
    }

    public override double CalculateArea()
    {
        return Length * Width;
    }

    
}