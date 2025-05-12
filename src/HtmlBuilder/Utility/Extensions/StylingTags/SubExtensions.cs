using System;

namespace HtmlBuilder.Tags.StylingTags;
public static class SubExtensions
{
    public static DoubleTagWithChildren Sub(this DoubleTagWithChildren doubleTag, Action<Sub> action)
    {
        Sub tag = new Sub();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}