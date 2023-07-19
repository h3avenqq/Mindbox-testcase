using FigureArea.Exceptions;
using FigureArea.Interfaces;

namespace FigureArea.Figures
{
    /// <summary>
    /// Represent a triangle
    /// </summary>
    public class Triangle : ICalculateArea
    {
        /// <summary>
        /// First side of a triangle
        /// </summary>
        public double SideA { get; set; }

        /// <summary>
        /// Second side of a triangle
        /// </summary>
        public double SideB { get; set; }

        /// <summary>
        /// Third side of a triangle
        /// </summary>
        public double SideC { get; set; }

        /// <summary>
        /// Initialize a triangle
        /// </summary>
        /// <param name="sideA">First side of a triangle</param>
        /// <param name="sideB">Second side of a triangle</param>
        /// <param name="sideC">Third side of a triangle</param>
        /// <exception cref="BadSidesException">Triangle with that sides doesn't exist</exception>
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (!IsCorrectTriangle(sideA, sideB, sideC))
                throw new BadSidesException(nameof(Triangle));

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        /// <summary>
        /// Returns area of a triangle
        /// </summary>
        /// <returns></returns>
        /// <exception cref="BadSidesException">Triangle with that sides doesn't exist</exception>
        public double GetArea()
        {
            if (!IsCorrectTriangle())
                throw new BadSidesException(nameof(Triangle));


            double p = (SideA + SideB + SideC) / 2;

            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        /// <summary>
        /// Checks if triangle is right
        /// </summary>
        public bool IsRightTriangle()
        {
            double aSquared = SideA * SideA;
            double bSquared = SideB * SideB;
            double cSquared = SideC * SideC;

            return aSquared == bSquared + cSquared || bSquared == aSquared + cSquared || cSquared == aSquared + bSquared;
        }

        /// <summary>
        /// Checks if given sides can form triangle
        /// </summary>
        /// <param name="sideA">First side of a triangle</param>
        /// <param name="sideB">Second side of a triangle</param>
        /// <param name="sideC">Third side of a triangle</param>
        private bool IsCorrectTriangle(double sideA, double sideB, double sideC)
            => sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;

        /// <summary>
        /// Checks if triangle with given sides can exist
        /// </summary>
        /// <param name="sideA">First side of a triangle</param>
        /// <param name="sideB">Second side of a triangle</param>
        /// <param name="sideC">Third side of a triangle</param>
        private bool IsValid(double sideA, double sideB, double sideC)
            => IsCorrectTriangle(sideA, sideB, sideC);


        /// <summary>
        /// Checks if triangle can exist with his sides
        /// </summary>
        /// <returns></returns>
        public bool IsCorrectTriangle()
            => IsCorrectTriangle(SideA, SideB, SideC);

    }
}
