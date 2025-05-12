namespace HtmlBuilder.Enums;

internal static class FormTargetExtensions
{
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
