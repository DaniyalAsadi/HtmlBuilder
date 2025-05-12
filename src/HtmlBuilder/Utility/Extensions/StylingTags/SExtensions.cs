using System;

namespace HtmlBuilder.Tags.StylingTags;
public static class SExtensions
{
    public static DoubleTagWithContent S(this DoubleTagWithChildren doubleTag, Action<S> action)
    {
        S tag = new S();
        action(tag);
        return tag;
    }
}