﻿namespace AdventOfSharedTools.Models
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
        public void Move(int value, Direction direction)
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
    }
}
