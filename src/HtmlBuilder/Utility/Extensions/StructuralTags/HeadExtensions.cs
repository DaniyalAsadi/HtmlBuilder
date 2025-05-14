using System;

namespace HtmlBuilder.Tags.StructuralTags;
public static class HeadExtensions
{
    public static DoubleHtmlElementWithChildren Head(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Head> action)
    {
        Head tag = new Head();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}