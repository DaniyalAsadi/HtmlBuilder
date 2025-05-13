using HtmlBuilder.Visitors;

namespace HtmlBuilder.Utility.Extensions.Visitors;
public static class HtmlVisitorExtensions
{
    /// <summary>
    /// To render the HTML tag in pretty Format
    /// </summary>
    public static string ToPrettyHtml(this BaseTag tag)
    {
        IHtmlRenderer renderer = new PrettyHtmlRenderer();

        return renderer.Render(tag);
    }
    /// <summary>
    /// To render the HTML tag in minimal Format
    /// </summary>
    public static string ToMinimalHtml(this BaseTag tag)
    {
        IHtmlRenderer renderer = new MinimalHtmlRenderer();
        return renderer.Render(tag);
    }
}
