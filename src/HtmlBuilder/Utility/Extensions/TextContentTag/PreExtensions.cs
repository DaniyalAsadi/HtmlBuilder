using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class PreExtensions
{
    public static DoubleTagWithContent Pre(this DoubleTagWithChildren doubleTag, Action<Pre> action)
    {
        Pre tag = new Pre();
        action(tag);
        return tag;
    }
}