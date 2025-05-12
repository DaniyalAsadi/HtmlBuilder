using System;

namespace HtmlBuilder.Tags.StylingTags;
public static class SmallExtensions
{
    public static Small Small(this DoubleTagWithChildren doubleTag, Action<Small> action)
    {
        Small tag = new Small();
        action(tag);
        return tag;
    }
}