public class Square
{
    private double Side;
    private double Area;

    public Square(double side)
    {
        Side = side;
    }
    public void AreaSquare(Square square)
    {
        Area = 2*square.Side;
    }

    public override string ToString() => $"El area del cuadrado es: {Area}";
}