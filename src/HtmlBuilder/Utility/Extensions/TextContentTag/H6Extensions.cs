using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class H6Extensions
{
    public static DoubleTagWithChildren H6(this DoubleTagWithChildren doubleTag, Action<H6> action)
    {
        H6 tag = new H6();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}