using System;

namespace HtmlBuilder.Tags.StructuralTags;
public static class FooterExtensions
{
    public static DoubleHtmlElementWithChildren Footer(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Footer> action)
    {
        Footer tag = new Footer();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}