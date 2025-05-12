using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class UlExtensions
{
    public static DoubleTagWithChildren Ul(this DoubleTagWithChildren doubleTag, Action<Ul> action)
    {
        Ul tag = new Ul();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}