namespace AdventOfSharedTools.Models
{
    /// <summary>
    /// Contains all possible Poker Hands starting from the lowest up to highest possible being Royal Flush.
    /// </summary>
    public enum PokerHandResult
    {
        None,
        Pair,
        TwoPairs,
        ThreeKind,
        Straight,
        Flush,
        FullHouse,
        FourKind,
        StraightFlush,
        RoyalFlush,
    }
}
