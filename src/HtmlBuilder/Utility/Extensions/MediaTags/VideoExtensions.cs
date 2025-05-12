namespace HtmlBuilder.Tags.MediaTags;
public static class VideoExtensions
{
    public static Video Video(this DoubleTagWithChildren doubleTag, Action<Video> action)
    {
        Video tag = new Video();
        action(tag);
        return tag;
    }

    public static Video SetSrc(this Video tag, string src)
    {
        tag.SetSrc(src);
        return tag;
    }

    public static Video SetControls(this Video tag)
    {
        tag.SetControls();
        return tag;
    }

    public static Video SetAutoplay(this Video tag)
    {
        tag.SetAutoplay();
        return tag;
    }

    public static Video SetLoop(this Video tag)
    {
        tag.SetLoop();
        return tag;
    }

    public static Video SetMuted(this Video tag)
    {
        tag.SetMuted();
        return tag;
    }

    public static Video SetWidth(this Video tag, string width)
    {
        tag.SetWidth(width);
        return tag;
    }

    public static Video SetHeight(this Video tag, string height)
    {
        tag.SetHeight(height);
        return tag;
    }
}
