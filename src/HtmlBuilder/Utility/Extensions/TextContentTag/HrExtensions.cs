using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class HrExtensions
{
    public static DoubleHtmlElementWithChildren Hr(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Hr> action)
    {
        Hr tag = new Hr();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}