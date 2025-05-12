using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class HrExtensions
{
    public static DoubleTagWithChildren Hr(this DoubleTagWithChildren doubleTag, Action<Hr> action)
    {
        Hr tag = new Hr();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}