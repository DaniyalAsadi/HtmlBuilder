using System;

namespace HtmlBuilder.Tags.TableTags;
public static class TableExtensions
{
    public static Table SetBorder(this Table tag, int border)
    {
        tag.SetBorder(border);
        return tag;
    }

    public static Table SetSummary(this Table tag, string summary)
    {
        tag.SetSummary(summary);
        return tag;
    }

    public static DoubleHtmlElementWithChildren Table(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Table> action)
    {
        Table tag = new Table();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}