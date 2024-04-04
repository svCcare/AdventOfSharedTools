using AdventOfSharedTools.Models;

namespace AdventOfSharedTools.Algorythms
{
    public static class FloodAlgorythm
    {
        public static IEnumerable<Location> Flood(Location floodLocation, char[,] matrix, char boundryChar)
        {
            Stack<Location> locationsToVisit = new Stack<Location>();
            List<Location> locationsFlooded = new List<Location>();
            locationsToVisit.Push(floodLocation);

            int sizeX = matrix.GetLength(0);
            int sizeY = matrix.GetLength(1);

            while (locationsToVisit.Count > 0)
            {
                var currentLocation = locationsToVisit.Pop();
                if (currentLocation.X >= 0 && currentLocation.X < sizeX && currentLocation.Y >= 0 && currentLocation.Y < sizeY)
                {
                    var fieldChar = matrix[currentLocation.X, currentLocation.Y];
                    if (fieldChar != boundryChar)
                    {
                        locationsFlooded.Add(currentLocation);

                        locationsToVisit.Push(currentLocation.Move(1, Direction.Up));
                        locationsToVisit.Push(currentLocation.Move(1, Direction.Right));
                        locationsToVisit.Push(currentLocation.Move(1, Direction.Down));
                        locationsToVisit.Push(currentLocation.Move(1, Direction.Left));
                    }
                }
            }

            return locationsFlooded;
        }
    }
}
