using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class BrExtensions
{
    public static DoubleHtmlElementWithChildren Br(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Br> action)
    {
        Br tag = new Br();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}