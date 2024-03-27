using FluentAssertions;
using Xunit;

namespace AdventOfSharedTools.Tests
{
    public class PrinterTests
    {
        [Theory]
        [InlineData(int.MinValue)]
        [InlineData(0)]
        [InlineData(int.MaxValue)]
        public void PrintResult_Works(int input)
        {
            var currentConsoleOut = Console.Out;

            using (var consoleOutput = new ConsoleOutputTestHelper())
            {
                Printer.PrintResult(input);
                var output = consoleOutput.GetOuput();
                output.Should().Be($"Result: {input}\r\n");
            }

            currentConsoleOut.Should().Be(Console.Out);
        }

        [Theory]
        [InlineData(int.MinValue, int.MinValue)]
        [InlineData(int.MinValue, 0)]
        [InlineData(0, int.MinValue)]
        [InlineData(0, 0)]
        [InlineData(0, int.MaxValue)]
        [InlineData(int.MaxValue, 0)]
        [InlineData(int.MaxValue, int.MaxValue)]
        [InlineData(int.MinValue, int.MaxValue)]
        [InlineData(int.MaxValue, int.MinValue)]
        public void PrintResults_WithoutTimes_Works(int resultPartOne, int resultPartTwo)
        {
            var currentConsoleOut = Console.Out;

            using (var consoleOutput = new ConsoleOutputTestHelper())
            {
                Printer.PrintResults(resultPartOne, resultPartTwo);
                var output = consoleOutput.GetOuput();
                output.Should().Be($"Part 1: {resultPartOne}\r\nPart 2: {resultPartTwo}\r\n");
            }

            currentConsoleOut.Should().Be(Console.Out);
        }

        [Theory]
        [InlineData(0, 0, 0, 0)]
        [InlineData(int.MinValue, int.MinValue, 0, 0)]
        [InlineData(int.MinValue, int.MinValue, int.MinValue, int.MinValue)]
        [InlineData(int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue)]
        public void PrintResults_WithTimes_Works(int resultPartOne, int resultPartTwo, int timeElapsedPartOne, int timeElapsedPartTwo)
        {
            var currentConsoleOut = Console.Out;

            using (var consoleOutput = new ConsoleOutputTestHelper())
            {
                Printer.PrintResults(resultPartOne, resultPartTwo, timeElapsedPartOne, timeElapsedPartTwo);
                var output = consoleOutput.GetOuput();
                output.Should().Be($"Part 1: {resultPartOne} | Solved in: {timeElapsedPartOne}ms\r\nPart 2: {resultPartTwo} | Solved in: {timeElapsedPartTwo}ms\r\n");
            }

            currentConsoleOut.Should().Be(Console.Out);
        }
    }
}
