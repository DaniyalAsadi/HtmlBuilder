using System;

namespace HtmlBuilder.Tags.MediaTags;
public static class AudioExtensions
{
    public static DoubleTagWithChildren Audio(this DoubleTagWithChildren doubleTag, Action<Audio> action)
    {
        Audio tag = new Audio();
        action(tag);
        return tag;
    }
}