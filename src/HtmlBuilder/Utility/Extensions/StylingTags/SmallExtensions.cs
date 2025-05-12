using System;

namespace HtmlBuilder.Tags.StylingTags;
public static class SmallExtensions
{
    public static DoubleTagWithChildren Small(this DoubleTagWithChildren doubleTag, Action<Small> action)
    {
        Small tag = new Small();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}