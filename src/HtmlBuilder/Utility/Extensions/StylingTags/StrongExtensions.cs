using System;

namespace HtmlBuilder.Tags.StylingTags;
public static class StrongExtensions
{
    public static DoubleTagWithChildren Strong(this DoubleTagWithChildren doubleTag, Action<Strong> action)
    {
        Strong tag = new Strong();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}