using AdventOfSharedTools.Models;
using FluentAssertions;
using Xunit;

namespace AdventOfSharedTools.Tests
{
    public class ExtensionMethodsTests
    {
        [Theory]
        [InlineData(CardShape.Heart, '♥')]
        [InlineData(CardShape.Diamond, '♦')]
        [InlineData(CardShape.Club, '♣')]
        [InlineData(CardShape.Spade, '♠')]
        public void CardShapeAsIcon_ForValidInput_ShouldReturnCorrectShape(CardShape cardShape, char expectedOutput)
        {
            var result = cardShape.CardShapeAsIcon();

            result.Should().Be(expectedOutput);
        }

        [Theory]
        [InlineData(1, 2, 12)]
        [InlineData(10, 22, 1022)]
        [InlineData(0, 0, 0)]
        [InlineData(1, 0, 10)]
        [InlineData(0, 1, 1)]
        public void JoinNumber_ForSimpleInput_WorksAsIntended(int numberA, int numberB, int expected)
        {
            var result = numberA.JoinNumber(numberB);

            result.Should().Be(expected);
        }

        [Fact]
        public void JoinNumber_WhenParameterIsNegativeNumber_ShouldThrowArgumentException()
        {
            var numberA = 1;
            var numberB = -2;

            Action act = () => numberA.JoinNumber(numberB);

            act.Should().Throw<ArgumentException>();
        }

        [Fact]
        public void JoinNumber_WhenJoinedNumbersAreTooBigForInt_ShouldThrowArgumentException()
        {
            var numberA = int.MaxValue;
            var numberB = int.MaxValue;

            Action act = () => numberA.JoinNumber(numberB);

            act.Should().Throw<ArgumentException>();
        }
    }
}
