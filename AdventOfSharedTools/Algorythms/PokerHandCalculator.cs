using AdventOfSharedTools.Models;

namespace AdventOfSharedTools.Algorythms
{
    /// <summary>
    /// Contains method to calculate hand in a poker game.
    /// </summary>
    public static class PokerHandCalculator
    {
        /// <summary>
        /// Calculates result of set of cards in a poker game.
        /// </summary>
        /// <param name="cards">Set of 5 cards which will be calculated.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">When incorrect number of cards is provided or illegal set of cards is given.</exception>
        public static PokerHandResult Calculate(IEnumerable<Card> cards)
        {
            if (cards.Count() is not 5)
            {
                throw new ArgumentException($"{nameof(PokerHandCalculator)} exception - {cards.Count()} is incorrect number of cards.");
            }

            var groups = cards.GroupBy(x => x).OrderByDescending(x => x.Count());

            return groups.Count() switch
            {
                1 => throw new ArgumentException($"{nameof(PokerHandCalculator)} exception - Invalid set of cards"),
                2 => groups.Any(x => x.Count() == 4) ? PokerHandResult.FourKind : PokerHandResult.FullHouse,
                3 => groups.Any(x => x.Count() == 3) ? PokerHandResult.ThreeKind : PokerHandResult.TwoPairs,
                4 => PokerHandResult.Pair,
                5 => CalculateByOrder(cards),
                _ => PokerHandResult.None,
            };
        }

        private static PokerHandResult CalculateByOrder(IEnumerable<Card> cards)
        {
            var sameShape = cards.GroupBy(x => x.Shape).Count() == 1;
            var hasAce = cards.Any(x => x.Type == CardType.Ace);

            var cardsInOrder = cards.OrderByDescending(x => x.Type).ToList();
            var cardsAreInOrder = true;
            for (int i = 0; i < cardsInOrder.Count - 1; i++)
            {
                if (cardsInOrder[i].Type - cardsInOrder[i + 1].Type != 1)
                {
                    cardsAreInOrder = false;
                }
            }

            return (sameShape, cardsAreInOrder, hasAce) switch
            {
                (false, false, _) => PokerHandResult.None,
                (true, false, _) => PokerHandResult.Flush,
                (false, true, _) => PokerHandResult.Straight,
                (true, true, false) => PokerHandResult.StraightFlush,
                (true, true, true) => PokerHandResult.RoyalFlush
            };
        }
    }
}
