using HtmlBuilder.Enums;

namespace HtmlBuilder.Tags.MediaTags;
public static class TrackExtensions
{
    public static Track Track(this DoubleTagWithChildren doubleTag, Action<Track> action)
    {
        Track tag = new Track();
        action(tag);
        return tag;
    }

    public static Track SetSrc(this Track tag, string src)
    {
        tag.SetSrc(src);
        return tag;
    }

    public static Track SetKind(this Track tag, TrackKind kind)
    {
        tag.SetKind(kind);
        return tag;
    }

    public static Track SetSrclang(this Track tag, string srclang)
    {
        tag.SetSrclang(srclang);
        return tag;
    }

    public static Track SetLabel(this Track tag, string label)
    {
        tag.SetLabel(label);
        return tag;
    }

    public static Track SetDefault(this Track tag)
    {
        tag.SetDefault();
        return tag;
    }
}
