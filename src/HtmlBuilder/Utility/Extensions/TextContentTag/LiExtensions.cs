using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class LiExtensions
{
    public static Li Li(this DoubleTagWithChildren doubleTag, Action<Li> action)
    {
        Li tag = new Li();
        action(tag);
        return tag;
    }

    public static Li SetValue(this Li tag, string value)
    {
        tag.SetValue(value);
        return tag;
    }
}