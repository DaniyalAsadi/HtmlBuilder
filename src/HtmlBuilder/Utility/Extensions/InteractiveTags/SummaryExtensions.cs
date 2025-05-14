using System;

namespace HtmlBuilder.Tags.InteractiveTags;
public static class SummaryExtensions
{
    public static DoubleHtmlElementWithChildren Summary(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Summary> action)
    {
        Summary tag = new Summary();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}