using System;

namespace HtmlBuilder.Tags.StylingTags;
public static class SubExtensions
{
    public static Sub Sub(this DoubleTagWithChildren doubleTag, Action<Sub> action)
    {
        Sub tag = new Sub();
        action(tag);
        return tag;
    }
}