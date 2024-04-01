namespace AdventOfSharedTools.Models;

/// <summary>
/// Model representing open range with start and end value.
/// </summary>
/// <typeparam name="T"></typeparam>
/// <param name="Start"></param>
/// <param name="End"></param>
public record RangeObject<T>(T Start, T End) where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
{
    /// <summary>
    /// Checks if given value lays between start and end values of this object.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public bool Contains(T value)
    {
        return Comparer<T>.Default.Compare(value, Start) > 0 && Comparer<T>.Default.Compare(value, End) < 0;
    }
}