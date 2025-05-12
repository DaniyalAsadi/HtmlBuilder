using System;

namespace HtmlBuilder.Tags.StylingTags;
public static class SExtensions
{
    public static DoubleTagWithChildren S(this DoubleTagWithChildren doubleTag, Action<S> action)
    {
        S tag = new S();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}