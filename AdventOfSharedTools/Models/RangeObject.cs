namespace AdventOfSharedTools.Models;

public record RangeObject<T>(T Start, T End) where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
{
    public bool Contains(T value)
    {
        return Comparer<T>.Default.Compare(value, Start) > 0 && Comparer<T>.Default.Compare(value, End) < 0;
    }
}