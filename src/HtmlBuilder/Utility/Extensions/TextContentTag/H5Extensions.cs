using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class H5Extensions
{
    public static DoubleTagWithContent H5(this DoubleTagWithChildren doubleTag, Action<H5> action)
    {
        H5 tag = new H5();
        action(tag);
        return tag;
    }
}