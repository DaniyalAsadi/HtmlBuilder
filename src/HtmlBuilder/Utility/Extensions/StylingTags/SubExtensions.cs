using System;

namespace HtmlBuilder.Tags.StylingTags;
public static class SubExtensions
{
    public static DoubleHtmlElementWithChildren Sub(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Sub> action)
    {
        Sub tag = new Sub();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}