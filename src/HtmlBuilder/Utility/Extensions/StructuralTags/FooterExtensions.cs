using System;

namespace HtmlBuilder.Tags.StructuralTags;
public static class FooterExtensions
{
    public static Footer Footer(this DoubleTagWithChildren doubleTag, Action<Footer> action)
    {
        Footer tag = new Footer();
        action(tag);
        return tag;
    }
}