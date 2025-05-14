using System;

namespace HtmlBuilder.Tags.StructuralTags;
public static class HtmlExtensions
{
    public static Html SetLang(this Html tag, string lang)
    {
        tag.SetLang(lang);
        return tag;
    }

    public static Html SetManifest(this Html tag, string manifestUrl)
    {
        tag.SetManifest(manifestUrl);
        return tag;
    }

    public static DoubleHtmlElementWithChildren Html(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Html> action)
    {
        Html tag = new Html();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}