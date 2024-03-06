using FluentAssertions;
using Xunit;

namespace AdventOfSharedTools.Tests
{
    public class CollectionExtensionsTests
    {
        [Fact]
        public void WithIndex_AssignsIndexCorrectly()
        {
            var collection = new string[] { "a", "b", "c" };
            var dictionary = new Dictionary<string, int>();

            foreach (var (item, index) in collection.WithIndex())
            {
                dictionary.Add(item, index);
            }

            dictionary.Should().HaveCount(collection.Length);
            dictionary["a"].Should().Be(0);
            dictionary["b"].Should().Be(1);
            dictionary["c"].Should().Be(2);
        }

        [Fact]
        public void WithIndex_ShouldThrowException_IfCollectionIsNull()
        {
            List<string> collection = null;

            Action act = () => collection.WithIndex();

            act.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void WithIndex_ShouldNotThrowException_IfCollectionIsEmpty()
        {
            var collection = Enumerable.Empty<string>();
            var dictionary = new Dictionary<string, int>();

            foreach (var (item, index) in collection.WithIndex())
            {
                dictionary.Add(item, index);
            }

            dictionary.Should().BeEmpty();
        }
    }
}
