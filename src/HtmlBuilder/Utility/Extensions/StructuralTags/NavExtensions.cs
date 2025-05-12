using System;

namespace HtmlBuilder.Tags.StructuralTags;
public static class NavExtensions
{
    public static DoubleTagWithChildren Nav(this DoubleTagWithChildren doubleTag, Action<Nav> action)
    {
        Nav tag = new Nav();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}