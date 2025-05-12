using System;

namespace HtmlBuilder.Tags.FormTags;
public static class LegendExtensions
{
    public static DoubleTagWithChildren Legend(this DoubleTagWithChildren doubleTag, Action<Legend> action)
    {
        Legend tag = new Legend();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}