using System;

namespace HtmlBuilder.Tags.StylingTags;
public static class StrongExtensions
{
    public static Strong Strong(this DoubleTagWithChildren doubleTag, Action<Strong> action)
    {
        Strong tag = new Strong();
        action(tag);
        return tag;
    }
}