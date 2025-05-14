using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class FigureExtensions
{
    public static DoubleHtmlElementWithChildren Figure(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Figure> action)
    {
        Figure tag = new Figure();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}