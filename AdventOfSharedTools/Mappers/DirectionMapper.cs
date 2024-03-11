using AdventOfSharedTools.Models;

namespace AdventOfSharedTools.Mappers
{
    /// <summary>
    /// Allows mapping to Direction object.
    /// </summary>
    public static class DirectionMapper
    {
        /// <summary>
        /// <para>Maps character onto Direction object.</para>
        /// Currently supported characters:
        /// <list type="bullet">
        /// <c>
        ///    <item> <description>'U' or 'N' => Direction.Up</description> </item>
        ///    <item> <description>'D' or 'S' => Direction.Down</description> </item>
        ///    <item> <description>'R' or 'E' => Direction.Right</description> </item>
        ///    <item> <description>'L' or 'W' => Direction.Left</description> </item>
        ///    </c>
        ///</list>
        /// </summary>
        /// <param name="input">Input to map. Case does not matter.</param>
        /// <returns>Direction object.</returns>
        /// <exception cref="ArgumentException"></exception>
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
