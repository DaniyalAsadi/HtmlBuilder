using System;

namespace HtmlBuilder.Tags.MediaTags;
public static class IframeExtensions
{
    public static SingleTag Iframe(this DoubleTagWithChildren doubleTag, Action<Iframe> action)
    {
        Iframe tag = new Iframe();
        action(tag);
        return tag;
    }
}