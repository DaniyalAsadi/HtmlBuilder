using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class PreExtensions
{
    public static DoubleHtmlElementWithChildren Pre(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Pre> action)
    {
        Pre tag = new Pre();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}