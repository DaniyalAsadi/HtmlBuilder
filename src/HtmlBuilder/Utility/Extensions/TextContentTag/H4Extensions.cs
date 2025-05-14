using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class H4Extensions
{
    public static DoubleHtmlElementWithChildren H4(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<H4> action)
    {
        H4 tag = new H4();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}