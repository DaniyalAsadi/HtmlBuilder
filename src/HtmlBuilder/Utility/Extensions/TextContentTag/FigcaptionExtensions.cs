using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class FigcaptionExtensions
{
    public static Figcaption Figcaption(this DoubleTagWithChildren doubleTag, Action<Figcaption> action)
    {
        Figcaption tag = new Figcaption();
        action(tag);
        return tag;
    }
}