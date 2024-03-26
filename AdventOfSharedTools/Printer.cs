namespace AdventOfSharedTools
{
    /// <summary>
    /// Contains useful methods to print messages to console.
    /// </summary>
    public static class Printer
    {
        /// <summary>
        /// Prints single line containing information about result of a challenge.
        /// </summary>
        /// <param name="result"></param>
        public static void PrintResult(int result)
        {
            Console.WriteLine($"Result: {result}");
        }

        /// <summary>
        /// Prints lines containing information about result of both parts.
        /// </summary>
        /// <param name="resultPartOne"></param>
        /// <param name="resultPartTwo"></param>
        public static void PrintResults(int resultPartOne = 0, int resultPartTwo = 0)
        {
            Console.WriteLine($"Part 1: {resultPartOne}");
            Console.WriteLine($"Part 2: {resultPartTwo}");
        }

        /// <summary>
        /// Prints lines containing information about result of both parts. Includes information about elapsed time in miliseconds.
        /// </summary>
        /// <param name="resultPartOne"></param>
        /// <param name="resultPartTwo"></param>
        /// <param name="timeElapsedPartOne"></param>
        /// <param name="timeElapsedPartTwo"></param>
        public static void PrintResults(int resultPartOne = 0, int resultPartTwo = 0, int timeElapsedPartOne = 0, int timeElapsedPartTwo = 0)
        {
            Console.WriteLine($"Part 1: {resultPartOne} | Solved in: {timeElapsedPartOne}ms");
            Console.WriteLine($"Part 2: {resultPartTwo} | Solved in: {timeElapsedPartTwo}ms");
        }
    }
}
