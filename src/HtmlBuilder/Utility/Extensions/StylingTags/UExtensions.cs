using System;

namespace HtmlBuilder.Tags.StylingTags;
public static class UExtensions
{
    public static U U(this DoubleTagWithChildren doubleTag, Action<U> action)
    {
        U tag = new U();
        action(tag);
        return tag;
    }
}