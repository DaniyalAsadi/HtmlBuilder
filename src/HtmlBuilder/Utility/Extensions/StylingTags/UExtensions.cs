using System;

namespace HtmlBuilder.Tags.StylingTags;
public static class UExtensions
{
    public static DoubleTagWithChildren U(this DoubleTagWithChildren doubleTag, Action<U> action)
    {
        U tag = new U();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}