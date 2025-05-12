using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class H3Extensions
{
    public static H3 H3(this DoubleTagWithChildren doubleTag, Action<H3> action)
    {
        H3 tag = new H3();
        action(tag);
        return tag;
    }
}