using System;

namespace HtmlBuilder.Tags.StylingTags;
public static class EmExtensions
{
    public static DoubleHtmlElementWithChildren Em(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Em> action)
    {
        Em tag = new Em();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}