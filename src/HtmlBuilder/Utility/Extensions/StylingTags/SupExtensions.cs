using System;

namespace HtmlBuilder.Tags.StylingTags;
public static class SupExtensions
{
    public static DoubleHtmlElementWithChildren Sup(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Sup> action)
    {
        Sup tag = new Sup();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}