using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class H6Extensions
{
    public static H6 H6(this DoubleTagWithChildren doubleTag, Action<H6> action)
    {
        H6 tag = new H6();
        action(tag);
        return tag;
    }
}