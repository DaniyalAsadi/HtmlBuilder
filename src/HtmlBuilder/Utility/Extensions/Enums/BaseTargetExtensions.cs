namespace HtmlBuilder.Enums;
internal static class BaseTargetExtensions
{
    /// <summary>
    /// Converts the BaseTarget enum to its string representation.
    /// </summary>
    /// <param name="target">The BaseTarget enum value.</param>
    /// <returns>The string representation of the BaseTarget enum.</returns>
    public static string ToHtmlString(this BaseTarget target)
    {
        return target switch
        {
            BaseTarget.Blank => "_blank",
            BaseTarget.Self => "_self",
            BaseTarget.Parent => "_parent",
            BaseTarget.Top => "_top",
            _ => throw new ArgumentOutOfRangeException(nameof(target), target, null)
        };
    }
}
