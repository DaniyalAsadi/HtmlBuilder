using System;

namespace HtmlBuilder.Tags.StylingTags;
public static class SExtensions
{
    public static DoubleHtmlElementWithChildren S(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<S> action)
    {
        S tag = new S();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}