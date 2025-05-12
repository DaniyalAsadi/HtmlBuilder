using System;

namespace HtmlBuilder.Tags.StylingTags;
public static class EmExtensions
{
    public static Em Em(this DoubleTagWithChildren doubleTag, Action<Em> action)
    {
        Em tag = new Em();
        action(tag);
        return tag;
    }
}