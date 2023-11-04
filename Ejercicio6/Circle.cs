namespace Ejercicio6;

public class Circle
{
    private double Radius;
    private double Area;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public void AreaCircle(Circle circle)
    {
        Area = Math.PI * (Math.Pow(circle.Radius, 2));
    }
    
    public override string ToString() => $"El area del circulo es: {Area}";
}