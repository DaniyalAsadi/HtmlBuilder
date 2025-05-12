using System;

namespace HtmlBuilder.Tags.MediaTags;
public static class VideoExtensions
{
    public static DoubleTagWithChildren Video(this DoubleTagWithChildren doubleTag, Action<Video> action)
    {
        Video tag = new Video();
        action(tag);
        return tag;
    }
}