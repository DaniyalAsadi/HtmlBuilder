using System;

namespace HtmlBuilder.Tags.StructuralTags;
public static class HeadExtensions
{
    public static Head Head(this DoubleTagWithChildren doubleTag, Action<Head> action)
    {
        Head tag = new Head();
        action(tag);
        return tag;
    }
}