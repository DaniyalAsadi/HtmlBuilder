using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class BrExtensions
{
    public static SingleTag Br(this DoubleTagWithChildren doubleTag, Action<Br> action)
    {
        Br tag = new Br();
        action(tag);
        return tag;
    }
}