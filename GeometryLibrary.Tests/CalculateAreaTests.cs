using GeometryLibrary.Core.Exceptions;
using GeometryLibrary.Core.Models;

namespace GeometryLibrary.Tests
{
    public class CalculateAreaTests
    {
        /// <summary>
        /// Точность для сравнения double-ов - допустим будет 3 знака после запятой.
        /// </summary>
        private const int Precision = 3;

        [Theory]
        [InlineData(15, 13, 17, 93.899880191617)]
        [InlineData(4, 3, 5, 6)]
        public void Triangle_ShouldCalculate_ValidArea(double a, double b, double c, double expected)
        {
            // Arrange
            GeometryBase triangle = new Triangle(a, b, c);

            // Act
            var area = triangle.Area;

            // Assert
            Assert.Equal(expected, area, Precision);
        }

        [Theory]
        [InlineData(-1, 1, 1)]
        [InlineData(1, -1, 1)]
        [InlineData(1, 1, -1)]
        public void Triangle_ShouldThrowArgException_On_InvalidParamsRange(double a, double b, double c)
        {
            // Arrange
            var act = () => new Triangle(a, b, c);

            // Act-Assert
            Assert.Throws<ArgumentOutOfRangeException>(act);
        }
        
        [Theory]
        [InlineData(100, 6, 2)]
        [InlineData(5, 100, 2)]
        [InlineData(6, 4, 100)]
        public void Triangle_ShouldThrowInvalidTriangle_On_InvalidSides(double a, double b, double c)
        {
            // Arrange
            var act = () => new Triangle(a, b, c);

            // Act-Assert
            Assert.Throws<InvalidTriangleException>(act);
        }

        [Theory]
        [InlineData(1, 3.142)]
        [InlineData(5, 78.54)]
        public void Circle_ShouldCalculate_ValidArea(double radius, double expected)
        {
            // Arrange
            GeometryBase triangle = new Circle(radius);

            // Act
            var area = triangle.Area;

            // Assert
            Assert.Equal(expected, area, Precision);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void Circle_ShouldThrowArgException_On_InvalidParamsRange(double radius)
        {
            // Arrange
            var act = () => new Circle(radius);

            // Act-Assert
            Assert.Throws<ArgumentOutOfRangeException>(act);
        }
    }
}