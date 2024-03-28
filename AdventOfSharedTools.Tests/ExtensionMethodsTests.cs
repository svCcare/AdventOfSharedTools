using FluentAssertions;
using Xunit;

namespace AdventOfSharedTools.Tests
{
    public class ExtensionMethodsTests
    {
        [Theory]
        [InlineData(1, 2, 12)]
        [InlineData(10, 22, 1022)]
        [InlineData(0, 0, 0)]
        [InlineData(1, 0, 10)]
        [InlineData(0, 1, 1)]
        public void MergeNumbers_ForSimpleInput_WorksAsIntended(int numberA, int numberB, int expected)
        {
            var result = numberA.JoinNumber(numberB);

            result.Should().Be(expected);
        }

        [Fact]
        public void MergeNumbers_WhenParameterIsNegativeNumber_ShouldThrowArgumentException()
        {
            var numberA = 1;
            var numberB = -2;

            Action act = () => numberA.JoinNumber(numberB);

            act.Should().Throw<ArgumentException>();
        }

        [Fact]
        public void MergeNumbers_WhenJoinedNumbersAreTooBigForInt_ShouldThrowArgumentException()
        {
            var numberA = int.MaxValue;
            var numberB = int.MaxValue;

            Action act = () => numberA.JoinNumber(numberB);

            act.Should().Throw<ArgumentException>();
        }
    }
}
