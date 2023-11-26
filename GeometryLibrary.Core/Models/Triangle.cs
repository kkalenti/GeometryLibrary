using GeometryLibrary.Core.Exceptions;

namespace GeometryLibrary.Core.Models;

public class Triangle : GeometryBase
{
    private readonly double _a;
    private readonly double _b;
    private readonly double _c;

    public Triangle(double a, double b, double c)
    {
        const string lessOrEqualToZeroMessage = "The edge cannot be less than or equal to zero.";

        if (a <= 0)
            throw new ArgumentOutOfRangeException(nameof(a), lessOrEqualToZeroMessage);

        if (b <= 0)
            throw new ArgumentOutOfRangeException(nameof(b), lessOrEqualToZeroMessage);

        if (c <= 0)
            throw new ArgumentOutOfRangeException(nameof(c), lessOrEqualToZeroMessage);

        // Проверяем, что стороны треугольника заданы корректно.
        if (a + b <= c || a + c <= b || b + c <= a)
            throw new InvalidTriangleException();

        _a = a;
        _b = b;
        _c = c;
    }

    public override double Area
    {
        get
        {
            var surface = _a + _b + _c;
            var halfSurface = surface / 2;
            var area = halfSurface * (halfSurface - _a) * (halfSurface - _b) * (halfSurface - _c);

            return Math.Sqrt(area);
        }
    }
}