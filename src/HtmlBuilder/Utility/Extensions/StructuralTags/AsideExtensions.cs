using System;

namespace HtmlBuilder.Tags.StructuralTags;
public static class AsideExtensions
{
    public static DoubleTagWithChildren Aside(this DoubleTagWithChildren doubleTag, Action<Aside> action)
    {
        Aside tag = new Aside();
        action(tag);
        return tag;
    }
}