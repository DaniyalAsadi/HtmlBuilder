namespace HtmlBuilder.Enums;
internal static class ATargetExtensions
{
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
