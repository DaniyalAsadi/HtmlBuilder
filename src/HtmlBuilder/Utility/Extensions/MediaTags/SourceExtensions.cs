using System;

namespace HtmlBuilder.Tags.MediaTags;
public static class SourceExtensions
{
    public static Source Source(this DoubleTagWithChildren doubleTag, Action<Source> action)
    {
        Source tag = new Source();
        action(tag);
        return tag;
    }

    public static Source SetSrc(this Source tag, string src)
    {
        tag.SetSrc(src);
        return tag;
    }

    public static Source SetType(this Source tag, string type)
    {
        tag.SetType(type);
        return tag;
    }
}