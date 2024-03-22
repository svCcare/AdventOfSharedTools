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

            //yield return new object[] { // TwoPairs
            //    new Card(CardType.Two, CardShape.Club),
            //    new Card(CardType.Two, CardShape.Heart),
            //    new Card(CardType.Four, CardShape.Diamond),
            //    new Card(CardType.Four, CardShape.Club),
            //    new Card(CardType.Five, CardShape.Club),
            //    PokerHandResult.TwoPairs
            //};

            //yield return new object[] { // ThreeKind
            //    new Card(CardType.Two, CardShape.Club),
            //    new Card(CardType.Two, CardShape.Heart),
            //    new Card(CardType.Two, CardShape.Diamond),
            //    new Card(CardType.Four, CardShape.Club),
            //    new Card(CardType.Five, CardShape.Club),
            //    PokerHandResult.ThreeKind
            //};

            //yield return new object[] { // Straight
            //    new Card(CardType.Two, CardShape.Club),
            //    new Card(CardType.Three, CardShape.Heart),
            //    new Card(CardType.Four, CardShape.Club),
            //    new Card(CardType.Five, CardShape.Club),
            //    new Card(CardType.Six, CardShape.Club),
            //    PokerHandResult.Straight
            //};

            //yield return new object[] { // Flush
            //    new Card(CardType.Two, CardShape.Club),
            //    new Card(CardType.Four, CardShape.Club),
            //    new Card(CardType.Five, CardShape.Club),
            //    new Card(CardType.Jack, CardShape.Club),
            //    new Card(CardType.Ace, CardShape.Club),
            //    PokerHandResult.Flush
            //};

            //yield return new object[] { // FullHouse
            //    new Card(CardType.Two, CardShape.Club),
            //    new Card(CardType.Two, CardShape.Heart),
            //    new Card(CardType.Three, CardShape.Club),
            //    new Card(CardType.Three, CardShape.Diamond),
            //    new Card(CardType.Three, CardShape.Spade),
            //    PokerHandResult.FullHouse
            //};

            //yield return new object[] { // FourKind
            //    new Card(CardType.Two, CardShape.Club),
            //    new Card(CardType.Two, CardShape.Heart),
            //    new Card(CardType.Two, CardShape.Diamond),
            //    new Card(CardType.Two, CardShape.Spade),
            //    new Card(CardType.Five, CardShape.Club),
            //    PokerHandResult.FourKind
            //};

            //yield return new object[] { // StraightFlush
            //    new Card(CardType.Two, CardShape.Club),
            //    new Card(CardType.Three, CardShape.Club),
            //    new Card(CardType.Four, CardShape.Club),
            //    new Card(CardType.Five, CardShape.Club),
            //    new Card(CardType.Six, CardShape.Club),
            //    PokerHandResult.StraightFlush
            //};

            //yield return new object[] { // RoyalFlush
            //    new Card(CardType.Ten, CardShape.Club),
            //    new Card(CardType.Jack, CardShape.Club),
            //    new Card(CardType.Queen, CardShape.Club),
            //    new Card(CardType.King, CardShape.Club),
            //    new Card(CardType.Ace, CardShape.Club),
            //    PokerHandResult.RoyalFlush
            //};
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}