namespace HtmlBuilder.Enums;
internal static class OlTypeExtensions
{
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
