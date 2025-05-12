using System;

namespace HtmlBuilder.Tags.StylingTags;
public static class EmExtensions
{
    public static DoubleTagWithChildren Em(this DoubleTagWithChildren doubleTag, Action<Em> action)
    {
        Em tag = new Em();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}