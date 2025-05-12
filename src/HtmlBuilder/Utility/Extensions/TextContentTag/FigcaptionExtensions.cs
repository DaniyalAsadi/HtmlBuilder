using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class FigcaptionExtensions
{
    public static DoubleTagWithChildren Figcaption(this DoubleTagWithChildren doubleTag, Action<Figcaption> action)
    {
        Figcaption tag = new Figcaption();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}