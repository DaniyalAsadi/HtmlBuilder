using System;

namespace HtmlBuilder.Tags.StructuralTags;
public static class AsideExtensions
{
    public static DoubleHtmlElementWithChildren Aside(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Aside> action)
    {
        Aside tag = new Aside();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}