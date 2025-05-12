using System;

namespace HtmlBuilder.Tags.FormTags;
public static class LegendExtensions
{
    public static Legend Legend(this DoubleTagWithChildren doubleTag, Action<Legend> action)
    {
        Legend tag = new Legend();
        action(tag);
        return tag;
    }
}