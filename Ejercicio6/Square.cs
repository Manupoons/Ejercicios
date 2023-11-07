using Ejercicio6;

public class Square : Shape
{
    private double Side { get; }
    

    public Square(double side)
    {
        Side = side;
    }

    public override double CalculateArea()
    {
        return Side * Side;
    }
}