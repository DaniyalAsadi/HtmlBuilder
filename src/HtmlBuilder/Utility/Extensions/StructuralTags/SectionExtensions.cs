using System;

namespace HtmlBuilder.Tags.StructuralTags;
public static class SectionExtensions
{
    public static Section Section(this DoubleTagWithChildren doubleTag, Action<Section> action)
    {
        Section tag = new Section();
        action(tag);
        return tag;
    }
}