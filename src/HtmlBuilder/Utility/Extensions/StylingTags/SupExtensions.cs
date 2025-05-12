using System;

namespace HtmlBuilder.Tags.StylingTags;
public static class SupExtensions
{
    public static DoubleTagWithChildren Sup(this DoubleTagWithChildren doubleTag, Action<Sup> action)
    {
        Sup tag = new Sup();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}