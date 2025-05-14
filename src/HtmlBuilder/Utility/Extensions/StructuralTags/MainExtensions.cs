using System;

namespace HtmlBuilder.Tags.StructuralTags;
public static class MainExtensions
{
    public static DoubleHtmlElementWithChildren Main(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Main> action)
    {
        Main tag = new Main();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}