using System;

namespace HtmlBuilder.Tags.StylingTags;
public static class MarkExtensions
{
    public static DoubleTagWithChildren Mark(this DoubleTagWithChildren doubleTag, Action<Mark> action)
    {
        Mark tag = new Mark();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}