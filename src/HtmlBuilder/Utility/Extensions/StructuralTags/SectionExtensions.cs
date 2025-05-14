using System;

namespace HtmlBuilder.Tags.StructuralTags;
public static class SectionExtensions
{
    public static DoubleHtmlElementWithChildren Section(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Section> action)
    {
        Section tag = new Section();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}