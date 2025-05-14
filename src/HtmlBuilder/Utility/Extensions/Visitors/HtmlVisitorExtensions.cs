using HtmlBuilder.Visitors;

namespace HtmlBuilder.Utility.Extensions.Visitors;
public static class HtmlVisitorExtensions
{
    /// <summary>
    /// To render the HTML htmlElement in pretty Format
    /// </summary>
    public static string ToPrettyHtml(this IHtmlElement htmlElement)
    {
        IHtmlRenderer renderer = new PrettyHtmlRenderer();

        return renderer.Render(htmlElement);
    }
    /// <summary>
    /// To render the HTML htmlElement in minimal Format
    /// </summary>
    public static string ToMinimalHtml(this IHtmlElement htmlElement)
    {
        IHtmlRenderer renderer = new MinimalHtmlRenderer();
        return renderer.Render(htmlElement);
    }
}
