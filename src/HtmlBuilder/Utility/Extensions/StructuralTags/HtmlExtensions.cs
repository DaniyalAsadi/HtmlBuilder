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

    public static DoubleTagWithChildren Html(this DoubleTagWithChildren doubleTag, Action<Html> action)
    {
        Html tag = new Html();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}