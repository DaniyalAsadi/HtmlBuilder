using System;

namespace HtmlBuilder.Tags.StylingTags;
public static class BExtensions
{
    public static DoubleTagWithChildren B(this DoubleTagWithChildren doubleTag, Action<B> action)
    {
        B tag = new B();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}