namespace GeometryLibrary.Core.Models;

public class Circle : IGeometry
{
    private readonly double _radius;

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentOutOfRangeException(nameof(radius), "The radius cannot be less than or equal to zero");

        _radius = radius;
    }

    public double Area => Math.PI * _radius * _radius;
}