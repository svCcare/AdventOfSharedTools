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
            var cardsCollection = GetCards(new(), cardsCount);

            Action act = () => PokerHandCalculator.Calculate(cardsCollection);

            act.Should().Throw<ArgumentException>();
        }

        [Fact]
        public void Calculate_WhenIllegalCombinationOfCards_ThrowsArgumentException()
        {
            var cardsCollection = GetCards(new(true, false, CardType.Two));

            Action act = () => PokerHandCalculator.Calculate(cardsCollection);

            act.Should().Throw<ArgumentException>();
        }

        [Theory]
        [ClassData(typeof(PokerHandCalculatorTestData))]
        public void Calculate_ForSetsOfCards_ReturnsExpectedResults(
            Card card1, Card card2, Card card3, Card card4, Card card5, PokerHandResult expectedResult)
        {
            var cardsCollection = new List<Card> { card1, card2, card3, card4, card5 };

            var result = PokerHandCalculator.Calculate(cardsCollection);

            result.Should().Be(expectedResult);
        }

        private static IEnumerable<Card> GetCards(CardGeneratorOptions options, int count = 5)
        {
            var cards = new List<Card>();
            for (int i = 0; i < count; i++)
            {
                var type = options.InOrder ? options.StartingCard + i : options.StartingCard;
                var shape = options.SameShape ? CardShape.Spade : (CardShape)Random.Shared.Next(0, 3);

                var card = new Card(type, shape);

                cards.Add(card);
            }

            return cards;
        }
    }

    // TODO better place for it?
    internal record class CardGeneratorOptions(bool SameShape = true, bool InOrder = true, CardType StartingCard = CardType.Two);
}
