using System;

namespace HtmlBuilder.Tags.StylingTags;
public static class IExtensions
{
    public static DoubleHtmlElementWithChildren I(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<I> action)
    {
        I tag = new I();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}