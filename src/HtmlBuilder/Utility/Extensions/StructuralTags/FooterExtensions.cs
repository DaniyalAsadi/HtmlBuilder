using System;

namespace HtmlBuilder.Tags.StructuralTags;
public static class FooterExtensions
{
    public static DoubleTagWithChildren Footer(this DoubleTagWithChildren doubleTag, Action<Footer> action)
    {
        Footer tag = new Footer();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}