using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class PreExtensions
{
    public static DoubleTagWithChildren Pre(this DoubleTagWithChildren doubleTag, Action<Pre> action)
    {
        Pre tag = new Pre();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}