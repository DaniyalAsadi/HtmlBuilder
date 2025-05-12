using System;

namespace HtmlBuilder.Tags.StylingTags;
public static class EmExtensions
{
    public static DoubleTagWithContent Em(this DoubleTagWithChildren doubleTag, Action<Em> action)
    {
        Em tag = new Em();
        action(tag);
        return tag;
    }
}