namespace HtmlBuilder.Enums;
/// <summary>
/// Provides extension methods for the <see cref="ATarget"/> enumeration.
/// </summary>
/// <remarks>This class contains methods to facilitate working with <see cref="ATarget"/> values, such as
/// converting them to their corresponding HTML string representations.</remarks>
internal static class ATargetExtensions
{
   /// <summary>
   /// Converts the specified <see cref="ATarget"/> value to its corresponding HTML string representation.
   /// </summary>
   /// <param name="target">The <see cref="ATarget"/> value to convert.</param>
   /// <returns>A string representing the HTML target attribute value corresponding to the specified <paramref name="target"/>.
   /// Returns an empty string if the <paramref name="target"/> value is not recognized.</returns>
    public static string ToHtmlString(this ATarget target)
    {
        return target switch
        {
            ATarget.Blank => "_blank",
            ATarget.Self => "_self",
            ATarget.Parent => "_parent",
            ATarget.Top => "_top",
            _ => string.Empty,
        };
    }
}
