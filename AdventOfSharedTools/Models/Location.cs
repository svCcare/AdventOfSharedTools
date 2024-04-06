namespace AdventOfSharedTools.Models
{
    /// <summary>
    /// Represent location on XY axis. Useful when trying to locate yourself over XY coordinate maps.
    /// </summary>
    /// <param name="X"></param>
    /// <param name="Y"></param>
    public record struct Location(int X, int Y)
    {
        /// <summary>
        /// Moves given amount of steps in specified direction.
        /// </summary>
        /// <param name="value">Cannot be negative. Throws ArgumentException in such case.</param>
        /// <param name="direction"></param>
        /// <exception cref="ArgumentException"></exception>
        public Location Move(int value, Direction direction)
        {
            if (value < 0)
                throw new ArgumentException($"Parameter {nameof(value)} cannot be negative.");

            switch (direction)
            {
                case Direction.Up:
                    this.Y = Y + value;
                    break;
                case Direction.Down:
                    this.Y = Y - value;
                    break;
                case Direction.Right:
                    this.X = X + value;
                    break;
                case Direction.Left:
                    this.X = X - value;
                    break;
                default:
                    break;
            }

            return this;
        }

        /// <summary>
        /// Updates coordinates to a given parameters X and Y.
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        public void Jump(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        /// <summary>
        /// Returns collection of all possible locations that are Ajacent to given location
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Location> GetAllAdjacentLocations()
        {
            List<Location> result = new List<Location>();

            result.Add(new Location(this.X - 1, this.Y - 1));
            result.Add(new Location(this.X, this.Y - 1));
            result.Add(new Location(this.X + 1, this.Y - 1));
            result.Add(new Location(this.X - 1, this.Y));
            result.Add(new Location(this.X + 1, this.Y));
            result.Add(new Location(this.X - 1, this.Y + 1));
            result.Add(new Location(this.X - 1, this.Y + 1));
            result.Add(new Location(this.X - 1, this.Y + 1));

            return result;
        }
    }
}
