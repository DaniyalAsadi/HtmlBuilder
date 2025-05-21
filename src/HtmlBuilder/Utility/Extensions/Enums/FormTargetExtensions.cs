namespace HtmlBuilder.Enums;
/// <summary>
/// Converts the specified <see cref="FormTarget"/> value to its corresponding HTML string representation.
/// </summary>
internal static class FormTargetExtensions
{
    /// <summary>
    /// Converts the specified <see cref="FormTarget"/> value to its corresponding HTML string representation.
    /// </summary>
    /// <param name="target">The <see cref="FormTarget"/> value to convert.</param>
    /// <returns>A string representing the HTML target attribute value corresponding to the specified <see cref="FormTarget"/>.
    /// For example, <see cref="FormTarget.Self"/> returns "_self".</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if the <paramref name="target"/> value is not a valid <see cref="FormTarget"/>.</exception>
    public static string ToHtmlString(this FormTarget target)
    {
        return target switch
        {
            FormTarget.Blank => "_blank",
            FormTarget.Parent => "_parent",
            FormTarget.Self => "_self",
            FormTarget.Top => "_top",
            _ => throw new ArgumentOutOfRangeException(nameof(target), target, null)
        };
    }
}
