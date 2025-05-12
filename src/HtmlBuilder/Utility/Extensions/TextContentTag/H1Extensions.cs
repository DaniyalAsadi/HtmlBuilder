using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class H1Extensions
{
    public static DoubleTagWithChildren H1(this DoubleTagWithChildren doubleTag, Action<H1> action)
    {
        H1 tag = new H1();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}