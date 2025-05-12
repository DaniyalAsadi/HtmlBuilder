using System;

namespace HtmlBuilder.Tags.MediaTags;
public static class SourceExtensions
{
    public static SingleTag Source(this DoubleTagWithChildren doubleTag, Action<Source> action)
    {
        Source tag = new Source();
        action(tag);
        return tag;
    }
}