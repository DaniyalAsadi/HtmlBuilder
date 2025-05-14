using System;

namespace HtmlBuilder.Tags.StylingTags;
public static class MarkExtensions
{
    public static DoubleHtmlElementWithChildren Mark(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Mark> action)
    {
        Mark tag = new Mark();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}