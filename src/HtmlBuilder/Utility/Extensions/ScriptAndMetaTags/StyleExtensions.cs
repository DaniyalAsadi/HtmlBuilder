using System;

namespace HtmlBuilder.Tags.ScriptAndMetaTags;
public static class StyleExtensions
{
    public static Style SetType(this Style tag, string type)
    {
        tag.SetType(type);
        return tag;
    }

    public static Style SetMedia(this Style tag, string media)
    {
        tag.SetMedia(media);
        return tag;
    }

    public static DoubleHtmlElementWithChildren Style(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Style> action)
    {
        Style tag = new Style();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}