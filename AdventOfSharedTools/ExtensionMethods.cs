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

        public static int JoinNumber(this int number, int anotherNumber)
        {
            var mergedAsString = number.ToString() + anotherNumber.ToString();

            if (int.TryParse(mergedAsString, out int result))
            {
                return result;
            }
            else
            {
                throw new ArgumentException($"Provided parameter number was in incorrect format");
            }
        }
    }
}