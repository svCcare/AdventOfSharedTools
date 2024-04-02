using AdventOfSharedTools.Models;
using System.Drawing;

namespace AdventOfSharedTools.Algorythms
{
    /// <summary>
    /// Use to calculate the area of a simple polygon knowing coordinates of all its points.
    /// </summary>
    public static class ShoelaceTheorem
    {
        public static long Calculate(IList<Location> locations)
        {
            long sumX = 0;
            long sumY = 0;

            for (int i = 0; i < locations.Count - 1; i++)
            {
                var currentPoint = locations[i];
                var nextPoint = locations[i + 1];

                sumX += currentPoint.X * nextPoint.Y;
                sumY += currentPoint.Y * nextPoint.X;
            }

            sumX += locations.Last().X * locations[0].Y;
            sumY += locations.Last().Y * locations[0].X;

            var result = Math.Abs(sumX - sumY) / 2;

            return result;
        }

        public static long Calculate(IList<Point> locations)
        {
            long sumX = 0;
            long sumY = 0;

            for (int i = 0; i < locations.Count - 1; i++)
            {
                var currentPoint = locations[i];
                var nextPoint = locations[i + 1];

                sumX += currentPoint.X * nextPoint.Y;
                sumY += currentPoint.Y * nextPoint.X;
            }

            sumX += locations.Last().X * locations[0].Y;
            sumY += locations.Last().Y * locations[0].X;

            var result = Math.Abs(sumX - sumY) / 2;

            return result;
        }

        public static long Calculate(IList<(int X, int Y)> locations)
        {
            long sumX = 0;
            long sumY = 0;

            for (int i = 0; i < locations.Count - 1; i++)
            {
                var currentPoint = locations[i];
                var nextPoint = locations[i + 1];

                sumX += currentPoint.X * nextPoint.Y;
                sumY += currentPoint.Y * nextPoint.X;
            }

            sumX += locations.Last().X * locations[0].Y;
            sumY += locations.Last().Y * locations[0].X;

            var result = Math.Abs(sumX - sumY) / 2;

            return result;
        }
    }
}
