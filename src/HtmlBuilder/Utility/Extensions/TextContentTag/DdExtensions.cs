using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class DdExtensions
{
    public static DoubleTagWithChildren Dd(this DoubleTagWithChildren doubleTag, Action<Dd> action)
    {
        Dd tag = new Dd();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}