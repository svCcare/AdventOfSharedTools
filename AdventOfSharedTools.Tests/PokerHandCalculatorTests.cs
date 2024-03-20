using AdventOfSharedTools.Algorythms;
using AdventOfSharedTools.Models;
using FluentAssertions;
using Xunit;

namespace AdventOfSharedTools.Tests
{
    public class PokerHandCalculatorTests
    {
        [Fact]
        public void Calculate_WhenNullParameter_ArgumentNullException()
        {
            Action act = () => PokerHandCalculator.Calculate(null);

            act.Should().Throw<ArgumentNullException>();
        }

        [Theory]
        [InlineData(0)]
        [InlineData(4)]
        [InlineData(6)]
        public void Calculate_WhenIncorrectNumberOfCards_ThrowsArgumentException(int cardsCount)
        {
            var cardsCollection = GetCards(cardsCount);

            Action act = () => PokerHandCalculator.Calculate(cardsCollection);

            act.Should().Throw<ArgumentException>();
        }

        [Fact]
        public void Calculate_WhenIllegalCombinationOfCards_ThrowsArgumentException()
        {
            var cardsCollection = GetCards(5); // generate 5 exact cards

            Action act = () => PokerHandCalculator.Calculate(cardsCollection);

            act.Should().Throw<ArgumentException>();
        }

        private static IEnumerable<Card> GetCards(int count)
        {
            var list = new List<Card>();
            for (int i = 0; i < count; i++)
            {
                list.Add(new Card(CardType.Two, CardShape.Diamond));
            }
            return list;
        }
    }
}
