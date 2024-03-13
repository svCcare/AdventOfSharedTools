using AdventOfSharedTools.Models;
using FluentAssertions;
using Xunit;

namespace AdventOfSharedTools.Tests
{
    public class LocationTests
    {
        [Fact]
        public void Location_DefaultInitialization_ShouldHaveZeroCoordinates()
        {
            var location = new Location();

            location.Should().NotBeNull();
            location.X.Should().Be(0);
            location.Y.Should().Be(0);
        }

        [Fact]
        public void Location_InitializedWithParameters_ShouldHaveSpecifiedCoordinates()
        {
            var location = new Location(2, 4);

            location.Should().NotBeNull();
            location.X.Should().Be(2);
            location.Y.Should().Be(4);
        }

        [Fact]
        public void Jump_ShouldUpdateLocation()
        {
            var location = new Location(2, 4);

            location.Jump(5, 7);

            location.Should().NotBeNull();
            location.X.Should().Be(5);
            location.Y.Should().Be(7);
        }

        [Theory]
        [InlineData(3, Direction.Up, 0, 3)]
        [InlineData(3, Direction.Down, 0, -3)]
        [InlineData(3, Direction.Right, 3, 0)]
        [InlineData(3, Direction.Left, -3, 0)]
        public void Move_ShouldUpdateLocation(int value, Direction direction, int expectedX, int expectedY)
        {
            var location = new Location();

            location.Move(value, direction);

            location.X.Should().Be(expectedX);
            location.Y.Should().Be(expectedY);
        }

        [Fact]
        public void Move_WhenNegativeValueParameter_ShouldThrowArgumentException()
        {
            var location = new Location();

            Action act = () => location.Move(-2, Direction.Up);

            act.Should().Throw<ArgumentException>($"Parameter value cannot be negative.");
        }
    }
}
