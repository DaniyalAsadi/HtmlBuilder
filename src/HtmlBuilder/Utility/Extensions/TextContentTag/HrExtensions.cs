using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class HrExtensions
{
    public static SingleTag Hr(this DoubleTagWithChildren doubleTag, Action<Hr> action)
    {
        Hr tag = new Hr();
        action(tag);
        return tag;
    }
}