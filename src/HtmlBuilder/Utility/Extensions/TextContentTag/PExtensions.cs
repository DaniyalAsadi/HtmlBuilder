using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class PExtensions
{
    public static DoubleTagWithContent P(this DoubleTagWithChildren doubleTag, Action<P> action)
    {
        P tag = new P();
        action(tag);
        return tag;
    }
}