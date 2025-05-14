using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class LiExtensions
{
    public static Li SetValue(this Li tag, string value)
    {
        tag.SetValue(value);
        return tag;
    }

    public static DoubleHtmlElementWithChildren Li(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Li> action)
    {
        Li tag = new Li();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}