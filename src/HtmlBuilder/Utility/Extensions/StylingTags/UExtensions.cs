using System;

namespace HtmlBuilder.Tags.StylingTags;
public static class UExtensions
{
    public static DoubleHtmlElementWithChildren U(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<U> action)
    {
        U tag = new U();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}