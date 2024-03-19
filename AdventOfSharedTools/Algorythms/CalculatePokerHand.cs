using AdventOfSharedTools.Models;

namespace AdventOfSharedTools.Algorythms
{
    public class CalculatePokerHand
    {
        public PokerHandResult Calculate(IEnumerable<Card> cards)
        {
            if (cards.Count() is not 5)
            {
                throw new ArgumentException($"{nameof(CalculatePokerHand)} exception - {cards.Count()} is incorrect number of cards.");
            }

            var groups = cards.GroupBy(x => x).OrderByDescending(x => x.Count());

            return groups.Count() switch
            {
                1 => throw new ArgumentException($"{nameof(CalculatePokerHand)} exception - Invalid set of cards"),
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

            var cardsInOrder = cards.OrderByDescending(x => x.Type).ToList();
            var cardsAreInOrder = true;
            for (int i = 0; i < cardsInOrder.Count - 1; i++)
            {
                if (cardsInOrder[i].Type - cardsInOrder[i + 1].Type != 1)
                {
                    cardsAreInOrder = false;
                }
            }

            return (sameShape, cardsAreInOrder) switch
            {
                (false, false) => PokerHandResult.None,
                (true, false) => PokerHandResult.Flush,
                (false, true) => PokerHandResult.Straight,
                (true, true) => cardsInOrder.First().Type == CardType.Ace
                    ? PokerHandResult.RoyalFlush
                    : PokerHandResult.StraightFlush
            };
        }
    }
}
