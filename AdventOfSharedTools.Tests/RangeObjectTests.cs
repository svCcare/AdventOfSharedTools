using AdventOfSharedTools.Models;
using FluentAssertions;
using Xunit;

namespace AdventOfSharedTools.Tests;

public class RangeObjectTests
{
    [Fact]
    public void Contains_Works()
    {
        var range = new RangeObject<int>(5, 8);

        var result = range.Contains(6);

        result.Should().BeTrue();
    }
}
