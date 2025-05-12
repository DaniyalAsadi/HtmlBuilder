using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class FigureExtensions
{
    public static DoubleTagWithChildren Figure(this DoubleTagWithChildren doubleTag, Action<Figure> action)
    {
        Figure tag = new Figure();
        action(tag);
        return tag;
    }
}