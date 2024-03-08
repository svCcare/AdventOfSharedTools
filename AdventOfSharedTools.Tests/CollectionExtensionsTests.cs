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

        [Fact]
        public void PopMax_OriginalCollectionIsModified_AndCorrectNumberIsReturned()
        {
            var collection = new List<int> { 1, 2 };

            var maxValue = collection.PopMax();

            maxValue.Should().Be(2);
            collection.Should().HaveCount(1);
            collection[0].Should().Be(1);
        }

        [Fact]
        public void PopMax_EmptyCollection_OriginalCollectionIsModified()
        {
            var collection = Enumerable.Empty<int>().ToList();

            Action act = () => collection.PopMax();

            act.Should().Throw<InvalidOperationException>();
        }

        [Fact]
        public void PopMax_CollectionWithTwoExactValues_OriginalCollectionIsModified()
        {
            var collection = new List<int> { 2, 2 };

            var maxValue = collection.PopMax();

            maxValue.Should().Be(2);
            collection.Should().HaveCount(1);
            collection[0].Should().Be(2);
        }

        [Fact]
        public void PopMax_FixedCollection_WillThrowNotSupportedException()
        {
            var collection = new int[2] { 1, 2 };

            Action act = () => collection.PopMax();

            act.Should().Throw<NotSupportedException>();
        }

        [Fact]
        public void PopMax_CalledOnNullObject_WillThrowArgumentNullException()
        {
            List<int> collection = null;

            Action act = () => collection.PopMax();

            act.Should().Throw<ArgumentNullException>();
        }
    }
}
