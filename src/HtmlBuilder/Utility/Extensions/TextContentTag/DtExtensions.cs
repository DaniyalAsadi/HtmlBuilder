using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class DtExtensions
{
    public static DoubleHtmlElementWithChildren Dt(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Dt> action)
    {
        Dt tag = new Dt();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}