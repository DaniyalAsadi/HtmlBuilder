using System;

namespace HtmlBuilder.Tags.StructuralTags;
public static class HtmlExtensions
{
    public static DoubleTagWithChildren Html(this DoubleTagWithChildren doubleTag, Action<Html> action)
    {
        Html tag = new Html();
        action(tag);
        return tag;
    }
}