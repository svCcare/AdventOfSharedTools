using System.Collections.Frozen;
using System.Collections.ObjectModel;

namespace AdventOfSharedTools
{
    /// <summary>
    /// Set of dictionaries that can help mapping phrases to other values.
    /// </summary>
    public static class UsefulDictionaries
    {
        private static readonly Dictionary<string, int> _numbers = new(StringComparer.InvariantCultureIgnoreCase)
        {
            { "zero", 0 },
            { "one", 1 },
            { "two", 2 },
            { "three", 3 },
            { "four", 4 },
            { "five", 5 },
            { "six", 6 },
            { "seven", 7 },
            { "eight", 8 },
            { "nine", 9 },
        };

        /// <summary>
        /// Contains names of numbers from 0 to 9.
        /// <para>Key case is ignored.</para>
        /// </summary>
        public static readonly ReadOnlyDictionary<string, int> NumbersReadOnly = new(_numbers);
        public static readonly FrozenDictionary<string, int> NumbersFrozen = _numbers.ToFrozenDictionary();
    }
}
