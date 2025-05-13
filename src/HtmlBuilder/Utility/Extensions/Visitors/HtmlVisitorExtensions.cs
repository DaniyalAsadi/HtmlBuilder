using HtmlBuilder.Visitors;

namespace HtmlBuilder.Utility.Extensions.Visitors;
public static class HtmlVisitorExtensions
{
    /// <summary>
    /// To render the HTML tag in pretty Format
    /// </summary>
    public static string ToPrettyHtml(this BaseTag tag)
    {
        var visitor = new PrettyHtmlVisitor();
        tag.Accept(visitor);
        return visitor.GetResult();
    }
    /// <summary>
    /// To render the HTML tag in minimal Format
    /// </summary>
    public static string ToMinimalHtml(this BaseTag tag)
    {
        var visitor = new MinimalHtmlVisitor();
        tag.Accept(visitor);
        return visitor.GetResult();
    }
}
