using System;

namespace HtmlBuilder.Tags.StylingTags;
public static class IExtensions
{
    public static I I(this DoubleTagWithChildren doubleTag, Action<I> action)
    {
        I tag = new I();
        action(tag);
        return tag;
    }
}