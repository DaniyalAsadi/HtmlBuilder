using System;

namespace HtmlBuilder.Tags.StylingTags;
public static class SpanExtensions
{
    public static DoubleHtmlElementWithChildren Span(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Span> action)
    {
        Span tag = new Span();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}