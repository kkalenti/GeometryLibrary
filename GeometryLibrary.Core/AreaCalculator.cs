using GeometryLibrary.Core.Models;

namespace GeometryLibrary.Core
{
    public class AreaCalculator
    {
        public double Calculate(GeometryBase geometry)
        {
            return geometry.Area;
        }
    }
}