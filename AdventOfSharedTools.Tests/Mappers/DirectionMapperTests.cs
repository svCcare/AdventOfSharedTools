using AdventOfSharedTools.Mappers;
using AdventOfSharedTools.Models;
using FluentAssertions;
using Xunit;

namespace AdventOfSharedTools.Tests.Mappers
{
    public class DirectionMapperTests
    {
        [Theory]
        [InlineData('U', Direction.Up)]
        [InlineData('N', Direction.Up)]

        [InlineData('D', Direction.Down)]
        [InlineData('S', Direction.Down)]

        [InlineData('R', Direction.Right)]
        [InlineData('E', Direction.Right)]

        [InlineData('L', Direction.Left)]
        [InlineData('W', Direction.Left)]
        public void FromChar_BasicInput_ShouldMapCorrectly(char input, Direction expectedOutput)
        {
            var result = DirectionMapper.FromChar(input);

            result.Should().Be(expectedOutput);
        }

        [Theory]
        [InlineData('u', Direction.Up)]
        [InlineData('n', Direction.Up)]

        [InlineData('d', Direction.Down)]
        [InlineData('s', Direction.Down)]

        [InlineData('r', Direction.Right)]
        [InlineData('e', Direction.Right)]

        [InlineData('l', Direction.Left)]
        [InlineData('w', Direction.Left)]
        public void FromChar_WhenInputInLowercase_ShouldMapCorrectly(char input, Direction expectedOutput)
        {
            var result = DirectionMapper.FromChar(input);

            result.Should().Be(expectedOutput);
        }

        [Fact]
        public void FromChar_InvalidCharacter_ShouldThrowNotImplementedException()
        {
            char invalidInput = '$';

            Action act = () => DirectionMapper.FromChar(invalidInput);

            act.Should().Throw<ArgumentException>("DirectionMapper is not able to map: '$'");
        }
    }
}
