namespace AdventOfSharedTools.Models
{
    public record struct Location(int X, int Y)
    {
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

        public void Jump(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
}
