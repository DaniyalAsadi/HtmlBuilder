using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class DdExtensions
{
    public static Dd Dd(this DoubleTagWithChildren doubleTag, Action<Dd> action)
    {
        Dd tag = new Dd();
        action(tag);
        return tag;
    }
}