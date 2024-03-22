using AdventOfSharedTools.Models;
using System.Text;

namespace AdventOfSharedTools
{
    public static class CollectionExtensions
    {
        /// <summary>
        /// Foreach iteration but gives access to current item index. Uses tuple object (T item, int index)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public static IEnumerable<(T item, int index)> WithIndex<T>(this IEnumerable<T> source)
        {
            return source.Select((item, index) => (item, index));
        }

        /// <summary>
        /// Obtains max element of a sequence, while removing it from original collection.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="NotSupportedException"></exception>
        /// <exception cref=""></exception>
        /// <returns></returns>
        public static T PopMax<T>(this IList<T> source) where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            var max = source.Max();
            source.Remove(max);

            return max;
        }


        public static string PrintCards(this IEnumerable<Card> cards)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var card in cards)
            {
                sb.Append(card.ToString());
                sb.Append(',');
            }
            return sb.ToString();
        }
    }
}
