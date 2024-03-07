using FluentAssertions;
using Xunit;

namespace AdventOfSharedTools.Tests
{
    public class StringExtensionsTests
    {
        [Fact]
        public void ReplaceWhitespace_WhenNoReplacementProvided_RemovesWhitespaces()
        {
            string input = "1 2 3";

            input = input.ReplaceWhitespace();

            input.Should().HaveLength(3);
        }

        [Fact]
        public void ReplaceWhitespace_ReplacementProvided_WhitespacesReplacedWithGivenParameter()
        {
            string input = "1 2 3";

            input = input.ReplaceWhitespace("_");

            input.Should().HaveLength(5);
            input.Should().Be("1_2_3");
        }

        [Fact]
        public void ReplaceWhitespace_ReplacementStringProvided_WhitespacesReplacedWithGivenParameter()
        {
            string input = "1 2 3";

            input = input.ReplaceWhitespace("::");

            input.Should().HaveLength(7);
            input.Should().Be("1::2::3");
        }

        [Fact]
        public void ReplaceWhitespace_NullString_ShouldThrowArgumentNullException()
        {
            string input = null;

            Action act = () => input.ReplaceWhitespace("<3");

            act.Should().Throw<ArgumentNullException>();
        }
    }
}
