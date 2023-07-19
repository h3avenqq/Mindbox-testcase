using FigureArea.Exceptions;
using FigureArea.Figures;

namespace FigureArea.Tests
{
    public class TriangleTests
    {

        [Fact]
        public void CalculateTriangleArea_Success()
        {
            // Arrange
            double aSide = 3;
            double bSide = 4;
            double cSide = 5;

            var triangle = new Triangle(aSide, bSide, cSide);


            //Act
            var result = triangle.GetArea();

            double p = (aSide + bSide + cSide) / 2;
            var expectedResult = Math.Sqrt(p * (p - aSide) * (p - bSide) * (p - cSide));

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(3,4,5)]
        [InlineData(4,5,6)]
        public void IsRightTriangle_Success(double aSide, double bSide, double cSide)
        {
            // Arrange
            var triangle = new Triangle(aSide, bSide, cSide);

            // Act
            var result = triangle.IsRightTriangle();

            double aSquared = aSide * aSide;
            double bSquared = bSide * bSide;
            double cSquared = cSide * cSide;

            var expectedResult = aSquared == bSquared + cSquared || bSquared == aSquared + cSquared || cSquared == aSquared + bSquared;

            // Assert
            Assert.Equal(result ,expectedResult);
        }


        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 1, 3)]
        [InlineData(3, 2, 1)]
        [InlineData(-3, 4, 5)]
        [InlineData(3, -4, 5)]
        [InlineData(3, 4, -5)]
        public void ConstructorTriangle_FailOnBadSides(double aSide, double bSide, double cSide)
        {
            Assert.Throws<BadSidesException>(() => new Triangle(aSide, bSide, cSide));
        }


        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 1, 3)]
        [InlineData(3, 2, 1)]
        [InlineData(-3, 4, 5)]
        [InlineData(3, -4, 5)]
        [InlineData(3, 4, -5)]
        public void CalculateTriangleArea_FailOnBadSides(double aSide, double bSide, double cSide)
        {
            var triangle = new Triangle(3,4,5);

            triangle.SideA = aSide;
            triangle.SideB = bSide;
            triangle.SideC = cSide;

            Assert.Throws<BadSidesException>(() => triangle.GetArea());
        }
    }
}
