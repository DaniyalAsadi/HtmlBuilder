using System;

namespace HtmlBuilder.Tags.StructuralTags;
public static class HeaderExtensions
{
    public static DoubleHtmlElementWithChildren Header(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Header> action)
    {
        Header tag = new Header();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}