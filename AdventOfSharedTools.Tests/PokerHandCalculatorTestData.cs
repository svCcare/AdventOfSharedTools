using AdventOfSharedTools.Models;
using System.Collections;
using Shape = AdventOfSharedTools.Models.CardShape;
using Type = AdventOfSharedTools.Models.CardType;

namespace AdventOfSharedTools.Tests
{
    internal class PokerHandCalculatorTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { // Pair
                new Card[] {
                    new(Type.Two, Shape.Club),
                    new(Type.Two, Shape.Heart),
                    new(Type.Three, Shape.Club),
                    new(Type.Four, Shape.Club),
                    new(Type.Five, Shape.Club),
                },
                PokerHandResult.Pair
            };

            yield return new object[] { // TwoPairs
                new Card[]
                {
                    new(Type.Two, Shape.Club),
                    new(Type.Two, Shape.Heart),
                    new(Type.Four, Shape.Diamond),
                    new(Type.Four, Shape.Club),
                    new(Type.Five, Shape.Club),
                },
                PokerHandResult.TwoPairs
            };

            yield return new object[] { // ThreeKind
                new Card[]
                {
                    new(Type.Two, Shape.Club),
                    new(Type.Two, Shape.Heart),
                    new(Type.Two, Shape.Diamond),
                    new(Type.Four, Shape.Club),
                    new(Type.Five, Shape.Club),
                },
                PokerHandResult.ThreeKind
            };

            yield return new object[] { // Straight
                new Card[]
                {
                    new(Type.Two, Shape.Club),
                    new(Type.Three, Shape.Heart),
                    new(Type.Four, Shape.Club),
                    new(Type.Five, Shape.Club),
                    new(Type.Six, Shape.Club),
                },
                PokerHandResult.Straight
            };

            yield return new object[] { // Flush
                new Card[]
                {
                    new(Type.Two, Shape.Club),
                    new(Type.Four, Shape.Club),
                    new(Type.Five, Shape.Club),
                    new(Type.Jack, Shape.Club),
                    new(Type.Ace, Shape.Club),
                },
                PokerHandResult.Flush
            };

            yield return new object[] { // FullHouse
                new Card[]
                {
                    new(Type.Two, Shape.Club),
                    new(Type.Two, Shape.Heart),
                    new(Type.Three, Shape.Club),
                    new(Type.Three, Shape.Diamond),
                    new(Type.Three, Shape.Spade),
                },
                PokerHandResult.FullHouse
            };

            yield return new object[] { // FourKind
                new Card[]
                {
                    new(Type.Two, Shape.Club),
                    new(Type.Two, Shape.Heart),
                    new(Type.Two, Shape.Diamond),
                    new(Type.Two, Shape.Spade),
                    new(Type.Five, Shape.Club),
                },
                PokerHandResult.FourKind
            };

            yield return new object[] { // StraightFlush
                new Card[]
                {
                    new(Type.Two, Shape.Club),
                    new(Type.Three, Shape.Club),
                    new(Type.Four, Shape.Club),
                    new(Type.Five, Shape.Club),
                    new(Type.Six, Shape.Club),
                },
                PokerHandResult.StraightFlush
            };

            yield return new object[] { // RoyalFlush
                new Card[]
                {
                    new(Type.Ten, Shape.Club),
                    new(Type.Jack, Shape.Club),
                    new(Type.Queen, Shape.Club),
                    new(Type.King, Shape.Club),
                    new(Type.Ace, Shape.Club),
                },
                PokerHandResult.RoyalFlush
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}