using System;

namespace HtmlBuilder.Tags.StructuralTags;
public static class NavExtensions
{
    public static DoubleHtmlElementWithChildren Nav(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Nav> action)
    {
        Nav tag = new Nav();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}