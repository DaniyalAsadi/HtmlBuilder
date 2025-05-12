using System;

namespace HtmlBuilder.Tags.InteractiveTags;
public static class SummaryExtensions
{
    public static DoubleTagWithContent Summary(this DoubleTagWithChildren doubleTag, Action<Summary> action)
    {
        Summary tag = new Summary();
        action(tag);
        return tag;
    }
}