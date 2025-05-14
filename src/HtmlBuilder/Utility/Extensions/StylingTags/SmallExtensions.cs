using System;

namespace HtmlBuilder.Tags.StylingTags;
public static class SmallExtensions
{
    public static DoubleHtmlElementWithChildren Small(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Small> action)
    {
        Small tag = new Small();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}