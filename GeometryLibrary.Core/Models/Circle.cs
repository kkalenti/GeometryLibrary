namespace GeometryLibrary.Core.Models;

public class Circle : IGeometry
{
    private readonly double _radius;

    /// <summary>
    /// Создает круг по радиусу.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">Возникает, если стороны треугольника меньше или равны 0.</exception>
    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentOutOfRangeException(nameof(radius), "The radius cannot be less than or equal to zero");

        _radius = radius;
    }

    public double Area => Math.PI * _radius * _radius;
}