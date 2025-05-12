namespace HtmlBuilder.Tags.MediaTags;
public static class IframeExtensions
{
    public static Iframe SetSrc(this Iframe tag, string src)
    {
        tag.SetSrc(src);
        return tag;
    }

    public static Iframe SetWidth(this Iframe tag, string width)
    {
        tag.SetWidth(width);
        return tag;
    }

    public static Iframe SetHeight(this Iframe tag, string height)
    {
        tag.SetHeight(height);
        return tag;
    }

    public static Iframe SetFrameborder(this Iframe tag, string frameborder)
    {
        tag.SetFrameborder(frameborder);
        return tag;
    }

    public static Iframe SetAllowFullscreen(this Iframe tag)
    {
        tag.SetAllowFullscreen();
        return tag;
    }

    public static DoubleTagWithChildren Iframe(this DoubleTagWithChildren doubleTag, Action<Iframe> action)
    {
        Iframe tag = new Iframe();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}