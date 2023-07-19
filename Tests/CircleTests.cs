using FigureArea.Exceptions;
using FigureArea.Figures;

namespace FigureArea.Tests
{
    public class CircleTests
    {
        [Fact]
        public void CalculateCircleArea_Success()
        {
            // Arrange
            double radius = 5.0;
            var circle = new Circle(radius);

            // Act
            var result = circle.GetArea();
            var expectedResult = Math.PI * radius * radius;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void CircleConstructor_FailOnNegativeRadius()
        {
            Assert.Throws<NegativeValueException>(() => new Circle(-1));
        }

        [Fact]
        public void CalculateCircleArea_FailOnNegativeRadius()
        {
            var circle = new Circle(5);

            circle.Radius = -1;

            Assert.Throws<NegativeValueException>(()=>circle.GetArea());
        }
    }
}
