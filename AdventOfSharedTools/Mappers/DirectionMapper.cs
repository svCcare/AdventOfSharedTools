using AdventOfSharedTools.Models;

namespace AdventOfSharedTools.Mappers
{
    public static class DirectionMapper
    {
        public static Direction FromChar(char input) =>
            input.ToString().ToUpper()[0] switch
            {
                'U' or 'N' => Direction.Up,
                'D' or 'S' => Direction.Down,
                'R' or 'E' => Direction.Right,
                'L' or 'W' => Direction.Left,
                _ => throw new ArgumentException($"{nameof(DirectionMapper)} is not able to map: '{input}'")
            };
    }
}
