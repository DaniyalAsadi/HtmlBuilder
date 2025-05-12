using System;

namespace HtmlBuilder.Tags.MediaTags;
public static class TrackExtensions
{
    public static SingleTag Track(this DoubleTagWithChildren doubleTag, Action<Track> action)
    {
        Track tag = new Track();
        action(tag);
        return tag;
    }
}