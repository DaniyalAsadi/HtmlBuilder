using System;

namespace HtmlBuilder.Tags.StylingTags;
public static class BExtensions
{
    public static DoubleHtmlElementWithChildren B(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<B> action)
    {
        B tag = new B();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}