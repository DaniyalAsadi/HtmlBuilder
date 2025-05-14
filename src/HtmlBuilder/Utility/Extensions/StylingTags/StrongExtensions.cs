using System;

namespace HtmlBuilder.Tags.StylingTags;
public static class StrongExtensions
{
    public static DoubleHtmlElementWithChildren Strong(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Strong> action)
    {
        Strong tag = new Strong();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}