using System;

namespace HtmlBuilder.Tags.StylingTags;
public static class SpanExtensions
{
    public static DoubleTagWithChildren Span(this DoubleTagWithChildren doubleTag, Action<Span> action)
    {
        Span tag = new Span();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}