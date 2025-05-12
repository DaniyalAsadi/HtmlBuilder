using System;

namespace HtmlBuilder.Tags.FormTags;
public static class LegendExtensions
{
    public static DoubleTagWithContent Legend(this DoubleTagWithChildren doubleTag, Action<Legend> action)
    {
        Legend tag = new Legend();
        action(tag);
        return tag;
    }
}