using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class H4Extensions
{
    public static H4 H4(this DoubleTagWithChildren doubleTag, Action<H4> action)
    {
        H4 tag = new H4();
        action(tag);
        return tag;
    }
}