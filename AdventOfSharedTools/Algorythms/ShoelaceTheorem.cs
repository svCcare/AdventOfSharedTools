using AdventOfSharedTools.Models;
using System.Drawing;

namespace AdventOfSharedTools.Algorythms
{
    /// <summary>
    /// Use to calculate the area of a simple polygon knowing coordinates of all its points.
    /// </summary>
    public static class ShoelaceTheorem
    {
        public static long Calculate(IList<Location> points)
        {
            long sumX = 0;
            long sumY = 0;

            for (int i = 0; i < points.Count - 1; i++)
            {
                var currentPoint = points[i];
                var nextPoint = points[i + 1];

                sumX += currentPoint.X * nextPoint.Y;
                sumY += currentPoint.Y * nextPoint.X;
            }

            sumX += points.Last().X * points[0].Y;
            sumY += points.Last().Y * points[0].X;

            var result = Math.Abs(sumX - sumY) / 2;

            return result;
        }

        public static long Calculate(IList<Point> points)
        {
            long sumX = 0;
            long sumY = 0;

            for (int i = 0; i < points.Count - 1; i++)
            {
                var currentPoint = points[i];
                var nextPoint = points[i + 1];

                sumX += currentPoint.X * nextPoint.Y;
                sumY += currentPoint.Y * nextPoint.X;
            }

            sumX += points.Last().X * points[0].Y;
            sumY += points.Last().Y * points[0].X;

            var result = Math.Abs(sumX - sumY) / 2;

            return result;
        }

        public static long Calculate(IList<(int X, int Y)> points)
        {
            long sumX = 0;
            long sumY = 0;

            for (int i = 0; i < points.Count - 1; i++)
            {
                var currentPoint = points[i];
                var nextPoint = points[i + 1];

                sumX += currentPoint.X * nextPoint.Y;
                sumY += currentPoint.Y * nextPoint.X;
            }

            sumX += points.Last().X * points[0].Y;
            sumY += points.Last().Y * points[0].X;

            var result = Math.Abs(sumX - sumY) / 2;

            return result;
        }
    }
}
