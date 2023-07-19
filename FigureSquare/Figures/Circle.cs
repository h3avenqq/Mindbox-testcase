using FigureArea.Exceptions;
using FigureArea.Interfaces;

namespace FigureArea.Figures
{
    /// <summary>
    /// Represent a circle
    /// </summary>
    public class Circle : ICalculateArea
    {
        /// <summary>
        /// Radius of a circle
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        /// Initialize circle
        /// </summary>
        /// <param name="radius">Radius of a circle</param>
        /// <exception cref="NegativeValueException">Negative value of a radius</exception>
        public Circle(double radius)
        {
            if (!IsValid(radius))
                throw new NegativeValueException(nameof(Circle));

            Radius = radius;
        }

        /// <summary>
        /// Returns area of a circle
        /// </summary>
        /// <returns>Area</returns>
        /// <exception cref="NegativeValueException">Negative value of a radius</exception>
        public double GetArea()
        {
            if (!IsValid())
                throw new NegativeValueException(nameof(Circle));

            return Math.PI * Radius * Radius; //ну или Math.Pow(), но в этом случае пару копеек проиграем на оптимизации при большом количестве вычислений
        }

        /// <summary>
        /// Checks if a circle with given radius is valid
        /// </summary>
        /// <param name="radius">Radius of a circle</param>
        private bool IsValid(double radius) => radius > 0;

        /// <summary>
        /// Checks if a circle is valid
        /// </summary>
        public bool IsValid() => IsValid(Radius);

    }
}
