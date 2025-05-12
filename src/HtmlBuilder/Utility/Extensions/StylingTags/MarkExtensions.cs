using System;

namespace HtmlBuilder.Tags.StylingTags;
public static class MarkExtensions
{
    public static Mark Mark(this DoubleTagWithChildren doubleTag, Action<Mark> action)
    {
        Mark tag = new Mark();
        action(tag);
        return tag;
    }
}