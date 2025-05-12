using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class BrExtensions
{
    public static DoubleTagWithChildren Br(this DoubleTagWithChildren doubleTag, Action<Br> action)
    {
        Br tag = new Br();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}