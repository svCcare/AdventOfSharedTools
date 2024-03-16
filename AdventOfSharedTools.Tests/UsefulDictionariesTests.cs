using FluentAssertions;
using Xunit;

namespace AdventOfSharedTools.Tests
{
    public class UsefulDictionariesTests
    {
        [Theory]
        [InlineData("zero", 0)]
        [InlineData("one", 1)]
        [InlineData("two", 2)]
        [InlineData("three", 3)]
        [InlineData("four", 4)]
        [InlineData("five", 5)]
        [InlineData("six", 6)]
        [InlineData("seven", 7)]
        [InlineData("eight", 8)]
        [InlineData("nine", 9)]
        public void UsefulDictionaries_ReturnCorrectData(string phrase, int expectedValue)
        {
            UsefulDictionaries.Numbers.Should().ContainKey(phrase);
            UsefulDictionaries.Numbers[phrase].Should().Be(expectedValue);
        }

        [Fact]
        public void UsefulDictionaries_CaseSensivity()
        {
            var keyName = "ONE";

            UsefulDictionaries.Numbers.Should().ContainKey(keyName);
            UsefulDictionaries.Numbers[keyName].Should().Be(1);
        }
    }
}
