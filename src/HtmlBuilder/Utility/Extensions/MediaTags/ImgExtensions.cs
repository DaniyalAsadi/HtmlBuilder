using System;

namespace HtmlBuilder.Tags.MediaTags;
public static class ImgExtensions
{
    public static Img SetSrc(this Img tag, string src)
    {
        tag.SetSrc(src);
        return tag;
    }

    public static Img SetAlt(this Img tag, string alt)
    {
        tag.SetAlt(alt);
        return tag;
    }

    public static Img SetWidth(this Img tag, string width)
    {
        tag.SetWidth(width);
        return tag;
    }

    public static Img SetHeight(this Img tag, string height)
    {
        tag.SetHeight(height);
        return tag;
    }

    public static DoubleTagWithChildren Img(this DoubleTagWithChildren doubleTag, Action<Img> action)
    {
        Img tag = new Img();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}