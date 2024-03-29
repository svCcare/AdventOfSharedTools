using AdventOfSharedTools.Models;

namespace AdventOfSharedTools
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// <para>Use to obtain more visual representation of Card Shape.</para>
        /// Examples:
        /// <list type="bullet">
        /// <c>
        ///    <item> <description>CardShape.Heart => ♥</description> </item>
        ///    <item> <description>CardShape.Diamond => ♦</description> </item>
        ///    <item> <description>CardShape.Club => ♣</description> </item>
        ///    <item> <description>CardShape.Spade => ♠</description> </item>
        ///</c>
        ///</list>
        /// </summary>
        /// <param name="shape"></param>
        /// <returns></returns>
        /// <exception cref="NotSupportedException"></exception>
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

        /// <summary>
        /// <para>Joins a number to another. Will throw <c>ArgumentException</c> if joined number extends Integer range or joined number is negative.</para>
        /// Examples:
        /// <list type="bullet">
        /// <c>
        ///    <item> <description>0 + 1 => 1</description> </item>
        ///    <item> <description>1 + 1 => 11</description> </item>
        ///    <item> <description>0 + 0 => 0</description> </item>
        ///    <item> <description>1 + 0 => 10</description> </item>
        ///</c>
        ///</list>
        ///</summary>
        /// <param name="number"></param>
        /// <param name="anotherNumber"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
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