using System;

namespace HtmlBuilder.Tags.StructuralTags;
public static class HeaderExtensions
{
    public static DoubleTagWithChildren Header(this DoubleTagWithChildren doubleTag, Action<Header> action)
    {
        Header tag = new Header();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}