namespace FigureArea.Additions
{
    /// <summary>
    /// Represents a point in a Cartesian coordinate system
    /// </summary>
    public class Point
    {
        /// <summary>
        /// X coordinate
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Y coordinate
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// Initialize object
        /// </summary>
        /// <param name="x">x coordinate</param>
        /// <param name="y">y coordinate</param>
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
