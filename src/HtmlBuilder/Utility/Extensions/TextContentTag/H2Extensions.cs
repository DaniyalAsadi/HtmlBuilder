using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class H2Extensions
{
    public static H2 H2(this DoubleTagWithChildren doubleTag, Action<H2> action)
    {
        H2 tag = new H2();
        action(tag);
        return tag;
    }
}