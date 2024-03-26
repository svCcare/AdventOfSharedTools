namespace AdventOfSharedTools
{
    public static class Printer
    {
        public static void PrintResult(int result)
        {
            Console.WriteLine($"Result: {result}");
        }

        public static void PrintResults(int resultPartOne = 0, int resultPartTwo = 0)
        {
            Console.WriteLine($"Part 1: {resultPartOne}");
            Console.WriteLine($"Part 2: {resultPartTwo}");
        }

        public static void PrintResults(int resultPartOne = 0, int resultPartTwo = 0, int timeElapsedPartOne = 0, int timeElapsedPartTwo = 0)
        {
            Console.WriteLine($"Part 1: {resultPartOne} | Solved in: {timeElapsedPartOne}ms");
            Console.WriteLine($"Part 2: {resultPartTwo} | Solved in: {timeElapsedPartTwo}ms");
        }
    }
}
