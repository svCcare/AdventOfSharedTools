using AdventOfSharedTools.Models;

namespace AdventOfSharedTools
{
    public static class ExtensionMethods
    {
        public static char CardShapeAsIcon(this CardShape shape)
        {
            return shape switch
            {
                CardShape.Heart => '♥',
                CardShape.Diamond => '♦',
                CardShape.Club => '♣',
                CardShape.Spade => '♠',
                _ => throw new NotSupportedException()
            };
        }
    }
}