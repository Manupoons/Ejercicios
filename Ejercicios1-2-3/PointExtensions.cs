namespace Ejercicios;

public static class PointExtensions
{
    public static Point Left(this Point point)
    {
        return new Point(point.X - 1, point.Y);
    }
    
    public static Point Right(this Point point)
    {
        return new Point(point.X + 1, point.Y);
    }
    
    public static Point Up(this Point point)
    {
        return new Point(point.X, point.Y + 1);
    }
    
    public static Point Down(this Point point)
    {
        return new Point(point.X, point.Y - 1);
    }
}