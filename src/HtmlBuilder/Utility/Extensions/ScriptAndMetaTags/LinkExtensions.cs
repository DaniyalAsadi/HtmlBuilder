using System;

namespace HtmlBuilder.Tags.ScriptAndMetaTags;
public static class LinkExtensions
{
    public static SingleTag Link(this DoubleTagWithChildren doubleTag, Action<Link> action)
    {
        Link tag = new Link();
        action(tag);
        return tag;
    }
}