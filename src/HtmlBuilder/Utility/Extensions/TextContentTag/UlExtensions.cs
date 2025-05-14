using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class UlExtensions
{
    public static DoubleHtmlElementWithChildren Ul(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Ul> action)
    {
        Ul tag = new Ul();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}