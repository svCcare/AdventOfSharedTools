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
    }
}
