using FigureArea.Additions;
using FigureArea.Interfaces;

namespace FigureArea.Figures
{
    public class Polygon : ICalculateArea
    {
        public IEnumerable<Point> Coordinates { get; set; }

        public Polygon(IEnumerable<Point> coordinates)
        {
            Coordinates = coordinates;
        }

        public double GetArea()
        {
            double sum = 0.0;

            var pointsArray = Coordinates.ToArray();

            int n = pointsArray.Length;

            for (int i = 0; i < n; i++)
            {
                int j = (i + 1) % n;
                sum += pointsArray[i].X * pointsArray[j].Y - pointsArray[j].X * pointsArray[i].Y;
            }

            return 0.5 * Math.Abs(sum);
        }
    }
}
