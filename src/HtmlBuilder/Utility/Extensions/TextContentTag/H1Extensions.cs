using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class H1Extensions
{
    public static DoubleHtmlElementWithChildren H1(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<H1> action)
    {
        H1 tag = new H1();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}