using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class LiExtensions
{
    public static DoubleTagWithContent Li(this DoubleTagWithChildren doubleTag, Action<Li> action)
    {
        Li tag = new Li();
        action(tag);
        return tag;
    }
}