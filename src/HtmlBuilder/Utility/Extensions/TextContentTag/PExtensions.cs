using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class PExtensions
{
    public static DoubleTagWithChildren P(this DoubleTagWithChildren doubleTag, Action<P> action)
    {
        P tag = new P();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}