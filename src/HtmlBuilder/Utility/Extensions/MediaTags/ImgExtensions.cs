using System;

namespace HtmlBuilder.Tags.MediaTags;
public static class ImgExtensions
{
    public static SingleTag Img(this DoubleTagWithChildren doubleTag, Action<Img> action)
    {
        Img tag = new Img();
        action(tag);
        return tag;
    }
}