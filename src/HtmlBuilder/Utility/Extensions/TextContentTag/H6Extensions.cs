using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class H6Extensions
{
    public static DoubleHtmlElementWithChildren H6(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<H6> action)
    {
        H6 tag = new H6();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}