using System;

namespace HtmlBuilder.Tags.StructuralTags;
public static class BodyExtensions
{
    public static DoubleHtmlElementWithChildren Body(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Body> action)
    {
        Body tag = new Body();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}