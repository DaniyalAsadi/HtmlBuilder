using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class DlExtensions
{
    public static DoubleHtmlElementWithChildren Dl(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Dl> action)
    {
        Dl tag = new Dl();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}