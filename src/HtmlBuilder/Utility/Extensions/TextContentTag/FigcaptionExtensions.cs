using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class FigcaptionExtensions
{
    public static DoubleHtmlElementWithChildren Figcaption(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Figcaption> action)
    {
        Figcaption tag = new Figcaption();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}