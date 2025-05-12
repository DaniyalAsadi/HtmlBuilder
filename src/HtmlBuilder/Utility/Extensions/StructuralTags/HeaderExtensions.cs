using System;

namespace HtmlBuilder.Tags.StructuralTags;
public static class HeaderExtensions
{
    public static Header Header(this DoubleTagWithChildren doubleTag, Action<Header> action)
    {
        Header tag = new Header();
        action(tag);
        return tag;
    }
}