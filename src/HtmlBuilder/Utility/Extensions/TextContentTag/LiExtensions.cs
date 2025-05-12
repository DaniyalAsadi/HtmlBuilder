using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class LiExtensions
{
    public static Li SetValue(this Li tag, string value)
    {
        tag.SetValue(value);
        return tag;
    }

    public static DoubleTagWithChildren Li(this DoubleTagWithChildren doubleTag, Action<Li> action)
    {
        Li tag = new Li();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}