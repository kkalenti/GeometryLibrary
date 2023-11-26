using GeometryLibrary.Core.Exceptions;

namespace GeometryLibrary.Core.Models;

public class Triangle : IGeometry
{
    private const string LessOrEqualToZeroMessage = "The edge cannot be less than or equal to zero.";

    private readonly double _a;
    private readonly double _b;
    private readonly double? _c;

    /// <summary>
    /// Создает прямоуголный треугольник по двум сторонам.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">Возникает, если стороны треугольника меньше или равны 0.</exception>
    public Triangle(double a, double b)
    {
        if (a <= 0)
            throw new ArgumentOutOfRangeException(nameof(a), LessOrEqualToZeroMessage);

        if (b <= 0)
            throw new ArgumentOutOfRangeException(nameof(b), LessOrEqualToZeroMessage);

        _a = a;
        _b = b;
    }

    /// <summary>
    /// Создает треугольник по трем сторонам.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">Возникает, если стороны треугольника меньше или равны 0.</exception>
    /// <exception cref="InvalidTriangleException">Возникает, если по переданным сторонам невозможно создать треугольник</exception>
    public Triangle(double a, double b, double c)
    {
        if (a <= 0)
            throw new ArgumentOutOfRangeException(nameof(a), LessOrEqualToZeroMessage);

        if (b <= 0)
            throw new ArgumentOutOfRangeException(nameof(b), LessOrEqualToZeroMessage);

        if (c <= 0)
            throw new ArgumentOutOfRangeException(nameof(c), LessOrEqualToZeroMessage);

        // Проверяем, что стороны треугольника заданы корректно.
        if (a + b <= c || a + c <= b || b + c <= a)
            throw new InvalidTriangleException();

        _a = a;
        _b = b;
        _c = c;
    }

    public double Area
    {
        get
        {
            if (_c is null)
            {
                return (_a * _b) / 2;
            }

            var surface = _a + _b + _c.Value;
            var halfSurface = surface / 2;
            var area = halfSurface * (halfSurface - _a) * (halfSurface - _b) * (halfSurface - _c.Value);

            return Math.Sqrt(area);
        }
    }
}