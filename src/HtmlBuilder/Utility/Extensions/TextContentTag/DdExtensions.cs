using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class DdExtensions
{
    public static DoubleHtmlElementWithChildren Dd(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Dd> action)
    {
        Dd tag = new Dd();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}