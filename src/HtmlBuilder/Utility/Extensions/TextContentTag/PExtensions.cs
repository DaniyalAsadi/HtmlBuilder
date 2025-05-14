using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class PExtensions
{
    public static DoubleHtmlElementWithChildren P(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<P> action)
    {
        P tag = new P();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}