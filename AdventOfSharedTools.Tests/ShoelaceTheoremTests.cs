using AdventOfSharedTools.Algorythms;
using AdventOfSharedTools.Models;
using FluentAssertions;
using System.Drawing;
using Xunit;

namespace AdventOfSharedTools.Tests
{
    public class ShoelaceTheoremTests
    {
        [Theory]
        [ClassData(typeof(ShoelaceTheoremTestData))]
        public void Calculate_ForLocation_YieldsCorrectResult(IEnumerable<int[]> points, long expectedArea)
        {
            var asLocation = points.Select(x => new Location(x[0], x[1])).ToList();

            var result = ShoelaceTheorem.Calculate(asLocation);

            result.Should().Be(expectedArea);
        }

        [Theory]
        [ClassData(typeof(ShoelaceTheoremTestData))]
        public void Calculate_ForPoint_YieldsCorrectResult(IEnumerable<int[]> points, long expectedArea)
        {
            var asPoint = points.Select(x => new Point(x[0], x[1])).ToList();

            var result = ShoelaceTheorem.Calculate(asPoint);

            result.Should().Be(expectedArea);
        }

        [Theory]
        [ClassData(typeof(ShoelaceTheoremTestData))]
        public void Calculate_ForTuple_YieldsCorrectResult(IEnumerable<int[]> points, long expectedArea)
        {
            var asTuple = points.Select(x => (x[0], x[1])).ToList();

            var result = ShoelaceTheorem.Calculate(asTuple);

            result.Should().Be(expectedArea);
        }
    }
}
