using System;

namespace HtmlBuilder.Tags.FormTags;
public static class LegendExtensions
{
    public static DoubleHtmlElementWithChildren Legend(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Legend> action)
    {
        Legend tag = new Legend();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}