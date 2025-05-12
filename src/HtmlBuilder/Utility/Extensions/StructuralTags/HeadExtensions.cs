using System;

namespace HtmlBuilder.Tags.StructuralTags;
public static class HeadExtensions
{
    public static DoubleTagWithChildren Head(this DoubleTagWithChildren doubleTag, Action<Head> action)
    {
        Head tag = new Head();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}