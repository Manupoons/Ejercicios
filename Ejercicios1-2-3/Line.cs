namespace Ejercicios;

public class Line
{
    
    public Point Start { get; set; }
    public Point End { get; set; }

    public Line(Point start, Point end)
    {
        Start = start;
        End = end;
    }

    public void Move(Point direction)
    {
        Start = new Point(Start.X + direction.X, Start.Y + direction.Y);
        End = new Point(End.X + direction.X, End.Y + direction.Y);
    }

    public static double Distance(Point start, Point end)
    {
        return Math.Sqrt(Math.Pow(end.X - start.X, 2) + Math.Pow(end.Y - start.Y, 2));
    }

    public override string ToString() => $"Punto: ({Start}, {End})";
}