namespace AdventOfSharedTools.Models
{
    /// <summary>
    /// Represents card object described by two properties - its type and shape.
    /// </summary>
    /// <param name="Type"></param>
    /// <param name="Shape"></param>
    public record Card(CardType Type, CardShape Shape);
}
