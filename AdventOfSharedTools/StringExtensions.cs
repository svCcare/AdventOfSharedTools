using System.Text.RegularExpressions;

namespace AdventOfSharedTools
{
    public static class StringExtensions
    {
        private static readonly Regex sWhitespace = new Regex(@"\s+");

        /// <summary>
        /// Use to replace each occurance of a whitespace with given string. If replacement is not given, whitespaces are removed.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="replacement"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RegexMatchTimeoutException"></exception>
        /// <returns></returns>
        public static string ReplaceWhitespace(this string input, string replacement = "")
        {
            return sWhitespace.Replace(input, replacement);
        }
    }
}
