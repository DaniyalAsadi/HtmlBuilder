using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class H3Extensions
{
    public static DoubleHtmlElementWithChildren H3(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<H3> action)
    {
        H3 tag = new H3();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}