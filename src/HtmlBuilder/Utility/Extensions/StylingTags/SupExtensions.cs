using System;

namespace HtmlBuilder.Tags.StylingTags;
public static class SupExtensions
{
    public static Sup Sup(this DoubleTagWithChildren doubleTag, Action<Sup> action)
    {
        Sup tag = new Sup();
        action(tag);
        return tag;
    }
}