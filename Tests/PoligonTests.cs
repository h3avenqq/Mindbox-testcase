using FigureArea.Additions;
using FigureArea.Figures;

namespace FigureArea.Tests
{
    public class PoligonTests
    {
        [Fact]
        public void CalculatePolygonArea_Success()
        {
            // Arrange
            var array = new[] { 
                new Point(2, 1), 
                new Point(4, 5), 
                new Point(7, 8) 
            };
            var polygon = new Polygon(array);

            // Act
            var result = polygon.GetArea();
            var expectedResult = 3;

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
