using AdventOfSharedTools.Models;
using System.Text;

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

        public static int MergeNumbers(params int[] numbers)
        {
            StringBuilder builder = new();
            builder.Append(numbers.Select(i => i.ToString()));

            return int.Parse(builder.ToString());
        }
    }
}