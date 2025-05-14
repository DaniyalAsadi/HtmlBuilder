using System;

namespace HtmlBuilder.Tags.ScriptAndMetaTags;
public static class NoscriptExtensions
{
    public static DoubleHtmlElementWithChildren Noscript(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Noscript> action)
    {
        Noscript tag = new Noscript();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}