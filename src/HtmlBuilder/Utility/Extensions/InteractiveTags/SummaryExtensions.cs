using System;

namespace HtmlBuilder.Tags.InteractiveTags;
public static class SummaryExtensions
{
    public static DoubleTagWithChildren Summary(this DoubleTagWithChildren doubleTag, Action<Summary> action)
    {
        Summary tag = new Summary();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}