using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class H5Extensions
{
    public static DoubleHtmlElementWithChildren H5(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<H5> action)
    {
        H5 tag = new H5();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}