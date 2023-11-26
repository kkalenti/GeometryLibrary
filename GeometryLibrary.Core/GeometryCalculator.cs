using GeometryLibrary.Core.Models;

namespace GeometryLibrary.Core
{
    // Не знаю, хватит ли поля в классах геометрий, поэтому добавил дополнительный класс.
    public class GeometryCalculator
    {
        public double CalculateArea(IGeometry geometry)
        {
            return geometry.Area;
        }
    }
}