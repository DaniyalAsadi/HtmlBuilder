namespace HtmlBuilder.Enums;
/// <summary>
/// Provides extension methods for the <see cref="OlType"/> enumeration.
/// </summary>
/// <remarks>This class includes methods to convert <see cref="OlType"/> values to their corresponding
/// representations, such as HTML string equivalents.</remarks>
internal static class OlTypeExtensions
{
    /// <summary>
    /// Converts the specified <see cref="OlType"/> value to its corresponding HTML string representation.
    /// </summary>
    /// <param name="type">The <see cref="OlType"/> value to convert.</param>
    /// <returns>A string representing the HTML value for the specified <see cref="OlType"/>.  For example, "1" for <see
    /// cref="OlType.Numeric"/> or "a" for <see cref="OlType.LowerAlpha"/>.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if the <paramref name="type"/> value is not a valid <see cref="OlType"/>.</exception>
    public static string ToHtmlString(this OlType type)
    {
        return type switch
        {
            OlType.Numeric => "1",
            OlType.LowerAlpha => "a",
            OlType.UpperAlpha => "A",
            OlType.LowerRoman => "i",
            OlType.UpperRoman => "I",
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
        };
    }
}
