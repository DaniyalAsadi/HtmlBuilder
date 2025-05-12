using System;

namespace HtmlBuilder.Tags.StylingTags;
public static class BExtensions
{
    public static B B(this DoubleTagWithChildren doubleTag, Action<B> action)
    {
        B tag = new B();
        action(tag);
        return tag;
    }
}