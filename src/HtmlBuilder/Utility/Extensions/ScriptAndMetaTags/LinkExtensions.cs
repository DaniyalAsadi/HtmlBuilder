using System;

namespace HtmlBuilder.Tags.ScriptAndMetaTags;
public static class LinkExtensions
{
    public static Link SetRel(this Link tag, string rel)
    {
        tag.SetRel(rel);
        return tag;
    }

    public static Link SetType(this Link tag, string type)
    {
        tag.SetType(type);
        return tag;
    }

    public static Link SetHref(this Link tag, string href)
    {
        tag.SetHref(href);
        return tag;
    }

    public static DoubleTagWithChildren Link(this DoubleTagWithChildren doubleTag, Action<Link> action)
    {
        Link tag = new Link();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}